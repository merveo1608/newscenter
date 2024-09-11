using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Execution;
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

        //projemde websitemin ana sayfas?d?r
        public IActionResult Index(int categoryID)
        {
            //burada haberlerimin tarihine göre ae?iv haber olup olmad???n?n ayarlamalar?n? yapt?m
            DateTime baseDate = new DateTime(2024, 1, 1);
            List<News> archiveNews= _newsManager.Where(x => x.PublishDate < baseDate && x.PublishDate !=null && x.Active == true).ToList();
            ViewBag.archiveNews = archiveNews;

            //newsmanager ile veritaban?ndan haberlerin stastüsü silinmemi? olanlar? ve active olanlar? listele 
            List<News> news = _newsManager.Where(x =>x.Status != DataStatus.Deleted && x.Active == true ).ToList();


            //kategri ?dsine göre haberleri filtreleyip viewbag ile viewa gönderir
            if(categoryID !=0)
            {
                news = news.Where(x => x.CategoryID == categoryID).ToList();
            }

            ViewBag.categoryID = categoryID;

            ViewBag.news = news;
            //haberler ve reklamlar listelenip viewa gönderdi
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
