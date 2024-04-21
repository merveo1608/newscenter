using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsCenter.Models.AppUsers;
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
            AppUser appUser = new()
            {
                UserName = r.UserName,
                Email = r.Email,
            };
            IdentityResult result = await _userManager.CreateAsync(appUser, r.Password);
            if (result.Succeeded)
            {
                AppUserProfile appUserProfile = new()
                {
                   ID = appUser.ID
                };

                TempData["Message"] = "Üyelik kaydınız başarılı";
                return RedirectToAction("Profile", appUserProfile);

            }
            else
            {

                TempData["Message"] = result.Errors.FirstOrDefault().Description;
                return RedirectToAction("Register");

            }


        }

        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(UserRegisterModel model)
        {
            AppUser appUser = await _userManager.FindByNameAsync(model.UserName);
            //bURAYA BİRLİKTE BAKIN MİCROSOFT IDENTİTY EKNDİ EKLEDİ
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, model.Password, true, true);
            if (result.Succeeded)
            {
                IList<string> roles = await _userManager.GetRolesAsync(appUser);
                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Category", new { Area = "Admin" });
                }
                else if (roles.Contains("Member"))
                {
                    return RedirectToAction("Privacy"); //todo ShoppingTool
                }
                return RedirectToAction("Panel");
            }
            else if (result.IsNotAllowed)
            {
                return RedirectToAction("MailPanel");
            }
            TempData["Message"] = "Kullanıcı bulunamadı";

            return RedirectToAction("SignIn");

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
