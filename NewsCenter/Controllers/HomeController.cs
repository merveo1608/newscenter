using Microsoft.AspNetCore.Mvc;
using NewsCenter.Models;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System.Diagnostics;

namespace NewsCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly INewsManager _newsManager;
        public HomeController(INewsManager newsManager )
        {
            _newsManager =newsManager;
        }

        public IActionResult Index()
        {
            List<News> news = _newsManager.GetAll().Where(x => x.Status != DataStatus.Deleted).ToList();
            ViewBag.news = news;
            return View(_newsManager.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
