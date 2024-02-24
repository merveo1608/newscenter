using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using NewsCenter.Areas.Admin.Models;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        INewsManager _newsManager;
        ICategoryManager _categoryManager;

        public NewsController(ICategoryManager categoryManager, INewsManager newsManager)
        {
            _categoryManager = categoryManager;
            _newsManager = newsManager;
        }

        public IActionResult Index()
        {
            return View(_newsManager.GetAll());
        }

        public IActionResult CreateNews()
        {
            List<Category> categories = _categoryManager.GetAll();
            ViewBag.categories = categories;

            CreateNewsPageVM cnVm = new CreateNewsPageVM()
            {
                Categories = _categoryManager.GetActives()
            };

            return View(cnVm);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNews(News news, IFormFile formFile)
        {
            #region Resim Yükleme Kodları

            Guid unigueName = Guid.NewGuid();

            string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını bu şekilde alırız.
            news.ImageURL = $"/images/{unigueName}{extension}";
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{news.ImageURL}";

            FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);
            #endregion

            news.AppUserID = 1;
            await _newsManager.AddAsync(news);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteNews(int id)
        {
            _newsManager.Delete(await _newsManager.FindAsync(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyNews(int id)
        {
            TempData["Message"] = _newsManager.Destroy(await _newsManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateNews(int id)
        {
            List<Category> categories = _categoryManager.GetAll();
            ViewBag.categories = categories;
            return View(await _newsManager.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNews(News model)
        {
            model.AppUserID = 1;
            await _newsManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }
    }
}
