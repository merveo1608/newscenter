using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.ContextClasses;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
  

        public IActionResult Index()
        {
            return View();
        }
    }
}
