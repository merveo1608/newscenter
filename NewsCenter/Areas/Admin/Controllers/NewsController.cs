using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using NewsCenter.Areas.Admin.Models;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
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
            ViewBag.activeMenu = "News";

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
            try
            {
                News a = await _newsManager.FindAsync(id);
                TempData["message"] = _newsManager.Destroy(await _newsManager.FindAsync(id));

                string filePath = $"{Directory.GetCurrentDirectory()}/wwwroot{a.ImageURL}";

                if (System.IO.File.Exists(filePath))
                {
                    //tekrar tekrar resim güncellemek istediğimde resim başka bir işlem tarafından kullanılmaktadır yazıyordu
                    //önceki işlemlerin sonlandırılması gerekiyordu googleda arama yaptım stackowerflowdan aşağıdaki kodları aldım
                   
                    System.GC.Collect();//garbage collectoru çalıştır
                    System.GC.WaitForPendingFinalizers();//daha önceki bitmek üzere olan işler varsa sonlanmasını bekle
                    System.IO.File.Delete(filePath);//Dosyayı bulunduğu adresten sil
                
                }
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
            {
                // Foreign key ihlaliyle ilgili özel işlem
                TempData["Message"] = "Bu haberi silemezsiniz, çünkü habere ait yorumlar bulunmaktadır.";
            }
            catch (Exception ex)
            {
                // Diğer tüm hatalar için genel bir yakalama bloğu
                TempData["Message"] = "Haberi silme işlemi sırasında bir hata oluştu: " + ex.Message;

            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateNews(int id)
        {
            List<Category> categories = _categoryManager.GetAll();
            ViewBag.categories = categories;
            return View(await _newsManager.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNews(News model, IFormFile formFile)
        {

            string oldImageURL = model.ImageURL;

            model.AppUserID = 1;

            #region Resim Yükleme Kodları
            if (formFile != null)
            {


                Guid unigueName = Guid.NewGuid();

                string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını bu şekilde alırız.
                model.ImageURL = $"/images/{unigueName}{extension}";
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";

                FileStream stream = new FileStream(path, FileMode.Create);
                formFile.CopyTo(stream);
            }
            #endregion

            //modeli veritabına kaydet/güncelle
            await _newsManager.UpdateAsync(model);

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
    }
}
