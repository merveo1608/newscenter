using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsCenter.Models.AppUsers;
using Newtonsoft.Json;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

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

                    // Kullanıcı girişi başarılı olduysa AppUser nesnesini Session'a kaydet
                    string userData = JsonConvert.SerializeObject(appUser, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    HttpContext.Session.SetString("AppUser", userData);

                    return RedirectToAction("Index", "Home");


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
                 if (result.Succeeded)
                {
                    AppUser appUser = await _userManager.FindByEmailAsync(model.Email);

                    // Kullanıcı girişi başarılı olduysa AppUser nesnesini Session'a kaydet
                    string userData = JsonConvert.SerializeObject(appUser, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    HttpContext.Session.SetString("AppUser", userData);


                    IList<string> roles = await _userManager.GetRolesAsync(appUser);
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

                ModelState.AddModelError(string.Empty, "Giriş Bilgieriniz Hatalı, Kontrol Ediniz !");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("AppUser");
            return RedirectToAction("SignIn", "User");
        }

        public IActionResult Profile()
        {
            return View();
     
        }

        [HttpPost]
        public async Task<IActionResult> Profile(AppUserProfile up )
        {
            return View();
        }
    }
}
