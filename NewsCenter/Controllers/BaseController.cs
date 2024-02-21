using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;

namespace NewsCenter.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICategoryManager _categoryManager;

        public BaseController()//ICategoryManager categoryManager
        {
            //_categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
