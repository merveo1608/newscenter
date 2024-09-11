
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class CommentController : Controller
    {
        readonly ICommentManager _commentManager;

        public CommentController(ICommentManager commentManager)
        {
            _commentManager = commentManager;
        }
        public IActionResult Index()
        {
            ViewBag.activeMenu = "Comment";
            List<Comment> data = _commentManager.GetAll();

            return View(data);
        }

        //yorum onaylama. Viewi yok oluşturulan butonun veritabanında iş yapmasını sağlar
        public async Task<IActionResult> ConfirmComment(int id)
        {
            Comment model = await _commentManager.FindAsync(id);
            model.CommentStatus = CommentStatus.Approved; //bulunan yoruun statüsünü onaylandı ya çek
            await _commentManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        //onayı geri alma 
        public async Task<IActionResult> RevorkComment(int id)
        {
            Comment model = await _commentManager.FindAsync(id);

            if (model == null)
            {
                return NotFound();
            }
            model.CommentStatus = CommentStatus.PendingApproval; // Onay bekliyora geri al
            await _commentManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        //yorumu reddet
        public async Task<IActionResult> RejectComment(int id)
        {
            Comment model = await _commentManager.FindAsync(id);

            if (model == null)
            {
                return NotFound();
            }
            model.CommentStatus = CommentStatus.Rejected; // Yorumu rejected(reddedildi) olarak ayarla
            await _commentManager.UpdateAsync(model);
            return RedirectToAction("Index");
        }
        //yorumu sil
        public async Task<IActionResult> DeleteComment(int id)
        {
            _commentManager.Delete(await _commentManager.FindAsync(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyComment(int id)
        {
            try
            {
                TempData["Message"] = _commentManager.Destroy(await _commentManager.FindAsync(id));

            }
            catch (Exception ex)
            {
                // Diğer tüm hatalar için genel bir yakalama bloğu
                TempData["Message"] = "Yorum silme işlemi sırasında bir hata oluştu: " + ex.Message;

            }
            return RedirectToAction("Index");
        }
    }
}
