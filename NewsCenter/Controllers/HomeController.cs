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
        readonly ICategoryManager _categoryManager;
        readonly IAdvertManager _advertManager;
        public HomeController(INewsManager newsManager, ICategoryManager categoryManager, IAdvertManager advertManager)
        {
            _newsManager = newsManager;
            _categoryManager = categoryManager;
            _advertManager = advertManager;
        }

        public IActionResult Index(int categoryID)
        {
            DateTime cutoffDate = new DateTime(2024, 1, 1);
            List<News> archiveNews= _newsManager.Where(x => x.PublishDate < cutoffDate && x.PublishDate !=null && x.Active == true).ToList();
            ViewBag.archiveNews = archiveNews;

            List<News> news = _newsManager.Where(x =>x.Status != DataStatus.Deleted && x.Active == true ).ToList();

            if(categoryID !=0)
            {
                news = news.Where(x => x.CategoryID == categoryID).ToList();
            }

            ViewBag.categoryID = categoryID;

            ViewBag.news = news;

            List<Advert> adverts = _advertManager.GetAll();
            ViewBag.adverts = adverts;
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

        public IActionResult GetPartialData()
        {
            List<Category> c = _categoryManager.GetAll();
            return PartialView("_NavbarPartial",c);
        }
    }
}
