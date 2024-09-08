using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Controllers
{
    public class ContactController : Controller
    {
        IContactManager _contactManager;
        readonly UserManager<AppUser> _userManager;
        public ContactController(IContactManager contactManager, UserManager<AppUser> userManager)
        {
            _contactManager = contactManager;
            _userManager = userManager;


        }
        public IActionResult Index()
        {
            Contact model = new Contact();  
            model.AppUserID = Convert.ToInt32(_userManager.GetUserId(User));
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(Contact model)
        {
            if (model.AppUserID == null || model.AppUserID ==0)
            {
                //TempData["message"] = "Kullanıcı girişi yapmadan iletişim formunu gönderemezsiniz!";
                return RedirectToAction("SignIn", "User");

            }
            else if (model.Subject == 0 ) //selectoptions kullanıldı seçilen konu türü boşsa
            {
                TempData["message"] = "Konu seçiniz!";
                return RedirectToAction("Index");
            }
            else if (string.IsNullOrEmpty(model.Description)) //açıklama bilgisi boşsa veya nuulsa 
            {
                TempData["message"] = "Mesaj içeriğini boş bırakamazsınız!";
                return RedirectToAction("Index");
            }
            await _contactManager.AddAsync(model); //gelen modeldeki verileri veritabanına kaydet
            TempData["message"] = "Mesajınız iletilmiştir";
            return RedirectToAction("Index");
        }
    }
}
