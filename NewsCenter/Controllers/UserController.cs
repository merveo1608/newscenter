using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsCenter.Models.AppUsers;
using Newtonsoft.Json;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;
using Project.COMMON.Tools;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.Security.Claims;

namespace NewsCenter.Controllers
{
    public class UserController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public IActionResult Register()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterModel r)
        {
            AppUser u = new AppUser();
            if (r.Email != null)
            {
                //kullanıcının girdiği emaili küçültür
                r.Email = r.Email.ToLower();
                //veritabanından email ile arama yap.
                u = await _userManager.FindByEmailAsync(r.Email);

            }

            if (u != null)
            {
                ModelState.AddModelError(string.Empty, "Bu email zaten kayıtlı başka email kullanınız!");

            }
            //Girilen şifreler birbirinden farklı ise 
            else if (r.Password != r.PasswordConfirm)
            {
                ModelState.AddModelError(string.Empty, "Şifreleriniz aynı değil kontrol ediniz!");

            }

            //Hiçbir sorun yoksa veritabanına kaydet
            else
            {
                PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>(); //IdentityFrameworkten gelir.Şifrelerin hashlenmesi ve doğrulanması için kullanılır.

                AppUser user = new()
                {
                    //Id = 1,
                    UserName = r.FirstName,
                    Email = r.Email,
                    NormalizedEmail = r.Email.ToUpper(),
                    NormalizedUserName = r.FirstName.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = passwordHasher.HashPassword(null, r.Password),
                    Profile = new AppUserProfile { FirstName = r.FirstName, LastName = r.LastName },
                };

                //yeni kullanıcı oluştur ve kaydet
                var result = await _userManager.CreateAsync(user, r.Password);

                //kayıt işlemi başarılıysa
                if (result.Succeeded)
                {
                    //kullanıcı profilini oluştur


                    // rol ata ve kaydet
                    await _userManager.AddToRoleAsync(user, "Visitor");

                    //kullanıcı oturum açmış olarak ayarla (singınmanager ıdentitty içinde var.)
                    AppUser appUser = await _userManager.FindByEmailAsync(user.Email);

                    #region sessiona veri kaydetme kodları
                    // Kullanıcı girişi başarılı olduysa AppUser nesnesini Session'a kaydet
                    //string userData = JsonConvert.SerializeObject(appUser, Formatting.None, new JsonSerializerSettings()
                    //{
                    //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    //});
                    //HttpContext.Session.SetString("AppUser", userData);
                    #endregion

                    #region üyelik doğrulama maili gönder
                    string body = $"Hesabınız olusturulmustur.Üyeliginizi onaylamak icin lütfen http://localhost:5089/User/ConfirmEmail?id={appUser.Id} linkine tıklayınız";
                    MailService.Send(r.Email, body: body,subject:"News Center Yeni Üye Kaydı Doğrulama");

                    TempData["Message"] = "Kayıt işlemi başarılı, Emailinizi kontrol ediniz,Kayıt işleminizi tamamlamak için, gelen maildeki linke tıklayın!";
                    #endregion

    


                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);

                }

            }


            return View(r);
            //AppUser appUser = new()
            //{
            //    UserName = r.UserName,
            //    Email = r.Email,
            //};
            //IdentityResult result = await _userManager.CreateAsync(appUser, r.Password);
            //if (result.Succeeded)
            //{
            //    AppUserProfile appUserProfile = new()
            //    {
            //       ID = appUser.ID
            //    };

            //    TempData["Message"] = "Üyelik kaydınız başarılı";
            //    return RedirectToAction("Profile", appUserProfile);

            //}
            //else
            //{

            //    TempData["Message"] = result.Errors.FirstOrDefault().Description;
            //    return RedirectToAction("Register");

            //}


        }

        public async Task<IActionResult> ConfirmEmail(int id)
        {
            // Kullanıcıyı Id ile bulma
            AppUser appUser = await _userManager.FindByIdAsync(id.ToString());

            // Email'i onaylanmış olarak işaretleme
            appUser.EmailConfirmed = true;

            // Kullanıcı bilgilerini güncelleme
            await _userManager.UpdateAsync(appUser);

            // Kullanıcıyı oturum açmış gibi işaretleme
            await _signInManager.SignInAsync(appUser, isPersistent: false);

            // Ana sayfaya yönlendirme
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                //emaile ait bir kullanıcı yoksa
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Giriş Bilgieriniz Hatalı, Kontrol Ediniz !");
                }else
                {
                 var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                    if (user.EmailConfirmed != true)
                    {
                        //mail gönderme kodları
                        #region üyelik doğrulama maili gönder
                        string body = $"Üyeliginizi onaylamak icin lütfen http://localhost:5089/User/ConfirmEmail?id={user.Id} linkine tıklayınız";
                        MailService.Send(user.Email, body: body, subject: "News Center Yeni Üye Kaydı Doğrulama");

                        #endregion


                        ModelState.AddModelError(string.Empty, "Emailiniz onaylanmamış, onaylama maili tekrar gönderilmiştir mail kutunuzu kontrol ediniz");

                    }
                    else if(result.Succeeded != true)
                    {
                        ModelState.AddModelError(string.Empty, "Giriş Bilgieriniz Hatalı, Kontrol Ediniz !");

                    }
                    else if (result.Succeeded)
                {
                    AppUser appUser = await _userManager.FindByEmailAsync(model.Email);

                    // Kullanıcı girişi başarılı olduysa AppUser nesnesini Session'a kaydet
                    //string userData = JsonConvert.SerializeObject(appUser, Formatting.None, new JsonSerializerSettings()
                    //{
                    //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    //});

                    //HttpContext.Session.SetString("AppUser", userData);


                    IList<string> roles = await _userManager.GetRolesAsync(appUser);
                        //if (roles.Count() > 0)
                        //{
                        //    HttpContext.Session.SetString("Roles", string.Join(",", roles));

                        //}
                        if (roles.Contains("Visitor"))
                    {
                        return RedirectToAction("Index", "Home"); //todo ShoppingTool
                    }
                    else 
                    {
                        //return RedirectToAction("SignIn","User"); //todo ShoppingTool
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }
                }
                }

            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signout()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("AppUser");
            return RedirectToAction("SignIn", "User");
        }

        public async Task<IActionResult> Profile()
        {
            // Oturum açmış kullanıcının ID'sini al
            var userId = _userManager.GetUserId(User);

            // Oturum açmış kullanıcının bilgilerini al
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcı bilgilerini view'a gönder
            return View(user);

        }

        [HttpPost]
        public async Task<IActionResult> Profile(AppUser updatedUser)
        {
            // Oturum açmış kullanıcının ID'sini al
            var userId = _userManager.GetUserId(User);

            // Oturum açmış kullanıcının bilgilerini al
            var appUser = await _userManager.FindByIdAsync(userId);
            appUser.Email = updatedUser.Email;
            appUser.Profile.FirstName = updatedUser.Profile.FirstName;
            appUser.Profile.LastName = updatedUser.Profile.LastName;
            // Kullanıcı bilgilerini güncelleme
            await _userManager.UpdateAsync(appUser);


            // Kullanıcıyı oturum açmış gibi işaretleme
            await _signInManager.SignInAsync(appUser, isPersistent: false);

            return View(updatedUser);

         // Oturum açmış kullanıcının ID'sini al
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcı profil bilgilerini güncelle
            //user.FirstName = updatedUser.FirstName;
            //user.LastName = updatedUser.LastName;
            //user.Address = updatedUser.Address;
            user.Email = updatedUser.Email; // E-posta gibi diğer alanlar

            // Kullanıcı bilgilerini güncelle ve sonucu kontrol et
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                // Güncelleme başarılı
                return RedirectToAction("Profile", new { message = "Profile updated successfully." });
            }
            else
            {
                // Hataları model state'e ekle
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Güncelleme başarısızsa, formu yeniden göster
            return View(user);
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                //usermanager ile veritabanına git ve modeldeki emaile ait kullanıcı bilgisini user nesnesine ata.
                AppUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    TempData["Message"] = "Email adresiniz geçersiz, geçerli bir Email adresi giriniz";

                    // Kullanıcı yoksa veya email doğrulanmamışsa, aynı sayfaya döndür
                    return View("ForgotPassword");
                }

                #region şifremi unuttum maili gönder
                string body = $"Şifrenizi güncellemek için linke tıklayınız http://localhost:5089/User/PasswordUpdate?email={user.Email} ";
                MailService.Send(model.Email, body: body, subject: "News Center Şifre Güncelleme");

                TempData["Message"] = "Emailinizi kontrol ediniz,Şifrenizi güncellemek için, gelen maildeki linke tıklayın!";
                #endregion

                return View("ForgotPassword");
            }

            // Model hatalıysa aynı sayfayı tekrar göster
            return View(model);
        }

        public IActionResult PasswordUpdate(string email )
        {
            PasswordUpdateModel model = new PasswordUpdateModel();
            model.Email = email;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> PasswordUpdate(PasswordUpdateModel model)
        {
            //ekrandan gelen emaile ait kullanıcıyı veritabanından bulma kodu.
            AppUser appUser = await _userManager.FindByEmailAsync(model.Email);

            //ekrandan girilen kullanıcı şifresini veritabanına kaydederken hashlemek için bu nesneyi kullandım
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            if (ModelState.IsValid)
            {
               
                    //Hashleme işlemi yapıldı
                    appUser.PasswordHash = passwordHasher.HashPassword(null, model.Password);

                    // Kullanıcı bilgilerini güncelleme
                    await _userManager.UpdateAsync(appUser);


                    // Kullanıcıyı oturum açmış gibi işaretleme
                    await _signInManager.SignInAsync(appUser, isPersistent: false);

                    // Şifre güncelleme işlemlerini burada yapabilirsiniz
                    TempData["Message"] = "Şifreniz başarıyla güncellendi.";
                

                return RedirectToAction("Index", "Home");

            }


            return View(model);
        }
}

}
