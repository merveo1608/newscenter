using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using NewsCenter.Areas.Admin.Models;
using NewsCenter.Models;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class NewsController : Controller
    {
        INewsManager _newsManager;
        ICategoryManager _categoryManager;
        UserManager<AppUser> _userManager;
        public NewsController(ICategoryManager categoryManager, INewsManager newsManager, UserManager<AppUser> userManager)
        {
            _categoryManager = categoryManager;
            _newsManager = newsManager;
            _userManager = userManager;
        }

        
        public IActionResult Index()
        {
            ViewBag.activeMenu = "News";

            List<News> data = _newsManager.GetAll().OrderByDescending(a => a.ID).ToList();
            return View(data);
        }
        public async Task<IActionResult> CreateNews()
        {
            List<Category> categories = _categoryManager.GetAll();
            categories.Insert(0, new Category {ID =0,CategoryName="-"});//select liste varsayılan optionu ekleme
            ViewBag.categories = categories;

            NewsViewModel model = new NewsViewModel();
            model.AppUserID = Convert.ToInt32(_userManager.GetUserId(User));
            model.PublishDate = null;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNews(NewsViewModel model, IFormFile? selectedImage)
        {
            //sayfadaki kategori listesini burada ayarlamak gerekiyor yoksa hata oluşur.
            List<Category> categories = _categoryManager.GetAll();
            categories.Insert(0, new Category { ID = 0, CategoryName = "-" });
            ViewBag.categories = categories;

            if (selectedImage == null && string.IsNullOrEmpty(model.ImageURL))
            {
                ModelState.AddModelError(string.Empty, "Tüm bilgileri giriniz.");
                return View(model);
            }

            //parametredeki modeldeki verilerde herhangi bir sorun yoksa
            else if (ModelState.IsValid)
            { 
                #region Resim Yükleme Kodları
                if (selectedImage != null)
                {
                    Guid unigueName = Guid.NewGuid();
                    string extension = Path.GetExtension(selectedImage.FileName); //dosyanın uzantısını bu şekilde alırız.
                    model.ImageURL = $"/images/{unigueName}{extension}";
                    string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";

                    FileStream stream = new FileStream(path, FileMode.Create);
                    selectedImage.CopyTo(stream);
                }
                #endregion

                News entity = new News() //veritabanında işlem yapılacak olan entitty classın instancesini alıp  view modeldeki verileri buna aktar
                {
                    Header = model.Header,
                    SortNumber = model.SortNumber,
                    Description = model.Description,
                    PublishDate = Convert.ToDateTime(model.PublishDate),
                    ImageURL = model.ImageURL,
                    Active = model.Active,
                    AppUserID = model.AppUserID,
                    CategoryID = model.CategoryID
                };
                await _newsManager.AddAsync(entity); /*veritabanına ekle*/
                return RedirectToAction("Index");
            }
            else
            {
                //şartlar sağlanmıyorsa tekrar modeli döndür
                return View(model);
            }
        }

        public async Task<IActionResult> DeleteNews(int id)
        {
            //newsmanagere veritabanından verilen id ye ait haberi bul ve sil görevi verildi
            _newsManager.Delete(await _newsManager.FindAsync(id)); 
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyNews(int id)
        {
            try
            {
                News a = await _newsManager.FindAsync(id);
                TempData["message"] = _newsManager.Destroy(await _newsManager.FindAsync(id));

                //getcurrentdirectory diyerek projenin dosya adresini aldım.
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
            categories.Insert(0, new Category { ID = 0, CategoryName = "-" });
            ViewBag.categories = categories;

            News news = await _newsManager.FindAsync(id);

            NewsViewModel model = new NewsViewModel() //view modele ana modeldeki bilgileri aktarma işlemi.
            {
                ID = news.ID,
                Header = news.Header,
                SortNumber = news.SortNumber,
                Description = news.Description,
                PublishDate = news.PublishDate,
                ImageURL = news.ImageURL,
                Active = news.Active,
                AppUserID = news.AppUserID,
                CategoryID = news.CategoryID
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNews(NewsViewModel model, IFormFile? selectedImage)
        {
            List<Category> categories = _categoryManager.GetAll();
            categories.Insert(0, new Category { ID = 0, CategoryName = "-" });
            ViewBag.categories = categories;

            if (selectedImage == null && string.IsNullOrEmpty(model.ImageURL))
            {
                ModelState.AddModelError(string.Empty, "Tüm bilgileri giriniz.");
                return View(model);
            }
            else if (ModelState.IsValid)
            {
                //önceki resmi bul ve sil
                string filePath = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";
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

                #region Resim Yükleme Kodları
                if (selectedImage != null)
                {


                    Guid unigueName = Guid.NewGuid();

                    string extension = Path.GetExtension(selectedImage.FileName); //dosyanın uzantısını bu şekilde alırız.
                    model.ImageURL = $"/images/{unigueName}{extension}";
                    string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";

                    FileStream stream = new FileStream(path, FileMode.Create);
                    selectedImage.CopyTo(stream);
                }
                #endregion

                //modeli veritabına kaydet/güncelle
                News news = new News()
                {
                    ID = model.ID,
                    Header = model.Header,
                    SortNumber = model.SortNumber,
                    Description = model.Description,
                    PublishDate = Convert.ToDateTime(model.PublishDate),
                    ImageURL = model.ImageURL,
                    Active = model.Active,
                    AppUserID = model.AppUserID,
                    CategoryID = model.CategoryID
                };
                await _newsManager.UpdateAsync(news);
            }

            return RedirectToAction("Index");
        }
    }
}
