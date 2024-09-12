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
            //burada 2024 yılından önceki haberleri arşiv haberler olarak viewBah e gönderdim
            DateTime baseDate = new DateTime(2024, 1, 1);
            ViewBag.archiveNews = _newsManager.Where(x => x.PublishDate < baseDate && x.PublishDate != null && x.Active == true).ToList();

            //newsmanager ile veritaban?ndan haberlerin stastüsü silinmemi? olanlar? ve active olanlar? listele ve ?uanki tarihten bir gün önceki
            List<News> news = _newsManager.Where(x =>x.Status != DataStatus.Deleted && x.Active == true && x.PublishDate > DateTime.Now.AddDays(-1)).ToList();


            //kategri idsine göre haberleri filtreleyip viewbag ile viewa gönderir
            if(categoryID !=0)
            {
                news = news.Where(x => x.CategoryID == categoryID).ToList();
            }

            ViewBag.categoryID = categoryID;

            ViewBag.news = news;
            //reklamlar
            ViewBag.adverts = _advertManager.GetAll().Where(x=> x.Status != DataStatus.Deleted); 

            return View();
        }
    }
}
