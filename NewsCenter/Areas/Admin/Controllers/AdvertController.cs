using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AdvertController : Controller
    {
        readonly IAdvertManager _advertManager;

        public AdvertController(IAdvertManager advertManager)
        {
            _advertManager = advertManager;
        }


        public IActionResult Index()
        {

            return View(_advertManager.GetAll());
        }

        public IActionResult CreateAdvert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdvert(Advert advert, IFormFile formFile)
        {
            #region Resim Yükleme Kodları

            Guid unigueName = Guid.NewGuid();

            string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını bu şekilde alırız.
            advert.ImageURL = $"/images/{unigueName}{extension}";
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{advert.ImageURL}";

            FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);
            #endregion

            await _advertManager.AddAsync(advert);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> UpdateAdvert(int id)
        {
            return View(await _advertManager.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdvert(Advert model)
        {
            await _advertManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteAdvert(int id)
        {
            _advertManager.Delete(await _advertManager.FindAsync(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyAdvert(int id)
        {
            TempData["Message"] = _advertManager.Destroy(await _advertManager.FindAsync(id));
            return RedirectToAction("Index");
        }
    }
}
