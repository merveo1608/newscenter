using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Controllers
{
    public class ContactController : Controller
    {
        IContactManager _contactManager;
        IAppUserManager _appUserManager;
        public ContactController(IContactManager contactManager, IAppUserManager appUserManager)
        {
            _contactManager = contactManager;
            _appUserManager = appUserManager;


        }
        public IActionResult Index()
        {
            TempData["message"] = "";

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Contact contact)
        {
            contact.AppUserID = 1;
            if (contact.Subject == 0 )
            {
                TempData["message"] = "Konu seçiniz!";
                return RedirectToAction("Index");

            }
            else if (string.IsNullOrEmpty(contact.Description))
            {

                TempData["message"] = "Mesaj içeriğini boş bırakamazsınız!";
                return RedirectToAction("Index");
            }
            //contact.AppUser = _appUserManager.Where(x => x.ID == 1).FirstOrDefault();
            //if (!ModelState.IsValid)
            //{
            //    // Zorunlu alanlar girilmemişse uyarı ekleyin
            //    return View(contact);

            //}
            await _contactManager.AddAsync(contact);
            TempData["message"] = "Mesajınız iletilmiştir";
            return RedirectToAction("Index");

        }
    }
}
