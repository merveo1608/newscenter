using Microsoft.AspNetCore.Mvc;

namespace NewsCenter.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login() 
        {
            return View(); 
        } 
    }
}
