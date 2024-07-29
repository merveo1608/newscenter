using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.ContextClasses;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")] // Sadece Admin ve editör rolüne sahip kullanıcılar erişebilir
    public class HomeController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            ViewBag.activeMenu = "Home";
            return View();
        }
    }
}
