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
            return View(_advertManager.GetAll());
        }

        //reklam eklemek için gerekli sayfa açılır.
        public IActionResult CreateAdvert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdvert(Advert advert, IFormFile formFile)
        {
            //1.adımda reklamın resmini sisteme yükle 
            #region Resim Yükleme Kodları

            Guid unigueName = Guid.NewGuid(); //guid yüklenen dosyanın benzersiz olmasını sağlar

            string extension = Path.GetExtension(formFile.FileName); //dosyanın uzantısını bu şekilde aldım.ör:bmp,jpg,jpeg
            advert.ImageURL = $"/images/{unigueName}{extension}"; //oluşturulsn guidle dosyanın uzantısı birleştirilir ve ımageurl ye atanır.
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot{advert.ImageURL}"; //bu metodu kullanarakta dosyanın fiziksel olarak kaydedileceği tam yolu beliriz.

            //parametredeki resim dosyasını path değişkenindeki adrese koyar
            FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);
            #endregion

            await _advertManager.AddAsync(advert); //2.adım reklamı veritabanına resim urlsi ile birlikte advertmanager kullanarak kaydet.
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> UpdateAdvert(int id)
        {
            //reklam güncelleme sayfası açılırken sayfanın modelini gönderiyorum
            Advert model = await _advertManager.FindAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdvert(Advert model, IFormFile selectedImage)
        {
            //önceki resmi bul ve sil,getcurrentdirectory diyerek projenin dosya adresini aldım.
            string filePath = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";
            if (System.IO.File.Exists(filePath)) //sistem io file kütüphanesini kullanarak verilen dosya adresinde bir dosya olup olmadığını kontrol etim
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
                Guid unigueName = Guid.NewGuid();//özel bir isim oluşjturyor benzersiz

                string extension = Path.GetExtension(selectedImage.FileName); //dosyanın uzantısını bu şekilde alırız.
                model.ImageURL = $"/images/{unigueName}{extension}";
                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{model.ImageURL}";

                FileStream stream = new FileStream(path, FileMode.Create);
                selectedImage.CopyTo(stream);
            }
            #endregion
            //reklamı veritabanına güncelle
            await _advertManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteAdvert(int id)
        {
            _advertManager.Delete(await _advertManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        //burada view oluşturmuyoruz var olan butonun veritabanında işlem yapabilmesini sağlıyoruz.
        public async Task<IActionResult> DestroyAdvert(int id)
        {
            //veritabanından reklamı silme işlemi
           Advert model = await _advertManager.FindAsync(id);
           string msg = _advertManager.Destroy(model);
            TempData["Message"] = msg;

            //silinenn reklama ait olan resmin silinme işlemi
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

            return RedirectToAction("Index");
        }
    }
}
