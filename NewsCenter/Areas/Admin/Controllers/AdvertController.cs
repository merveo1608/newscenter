using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]

    public class AdvertController : Controller
    {
        readonly IAdvertManager _advertManager;

        public AdvertController(IAdvertManager advertManager)
        {
            _advertManager = advertManager;
        }


        public IActionResult Index()
        {
            ViewBag.activeMenu = "Advert";

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
        public async Task<IActionResult> UpdateAdvert(Advert model, IFormFile formFile)
        {
            string oldImageURL = model.ImageURL;
            #region Resim Yükleme Kodları

            if (formFile != null)
            {
                Guid unigueName = Guid.NewGuid();//özel bir isim oluşjturyor benzersiz

                string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını bu şekilde alırız.
                model.ImageURL = $"/images/{unigueName}{extension}";
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";

                FileStream stream = new FileStream(path, FileMode.Create);
                formFile.CopyTo(stream);
            }
            #endregion
            //reklamı veritabanına güncelle
            await _advertManager.UpdateAsync(model);

            //önceki resmi bul ve sil
            string filePath = $"{Directory.GetCurrentDirectory()}/wwwroot{oldImageURL}";
            
           
            if (formFile != null)   //gözat ile yeni bir resim seçilmişse
            {
                //bulduğun eski resmi sil

                if (System.IO.File.Exists(filePath))
                {
                    //tekrar tekrar resim güncellemek istediğimde resim başka bir işlem tarafından kullanılmaktadır yazıyordu
                    //önceki işlemlerin sonlandırılması gerekiyordu googleda arama yaptım stackowerflowdan aşağıdaki kodları aldım
                    try
                    {
                        System.GC.Collect();//garbage collectoru çalıştır
                        System.GC.WaitForPendingFinalizers();//daha önceki bitmek üzere olan işler varsa sonlanmasını bekle
                        System.IO.File.Delete(filePath);//Dosyayı bulunduğu adresten sil
                    }
                    catch (Exception e)
                    {

                    }
                }
            }


            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteAdvert(int id)
        {
            _advertManager.Delete(await _advertManager.FindAsync(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyAdvert(int id)
        {
            Advert a = await _advertManager.FindAsync(id);
            TempData["Message"] = _advertManager.Destroy(await _advertManager.FindAsync(id));

            string filePath = $"{Directory.GetCurrentDirectory()}/wwwroot{a.ImageURL}";

            if (System.IO.File.Exists(filePath))
            {
                //tekrar tekrar resim güncellemek istediğimde resim başka bir işlem tarafından kullanılmaktadır yazıyordu
                //önceki işlemlerin sonlandırılması gerekiyordu googleda arama yaptım stackowerflowdan aşağıdaki kodları aldım
                try
                {
                    System.GC.Collect();//garbage collectoru çalıştır
                    System.GC.WaitForPendingFinalizers();//daha önceki bitmek üzere olan işler varsa sonlanmasını bekle
                    System.IO.File.Delete(filePath);//Dosyayı bulunduğu adresten sil
                }
                catch (Exception e)
                {

                }
            }

            return RedirectToAction("Index");
        }
    }
}
