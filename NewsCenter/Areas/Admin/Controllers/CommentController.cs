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

    public class CommentController : Controller
    {
        readonly ICommentManager _commentManager;

        public CommentController(ICommentManager commentManager)
        {
            _commentManager = commentManager;
        }
        public IActionResult Index()
        {
            List<Comment> c = _commentManager.GetAll();

            return View(c);
        }

        public async Task<IActionResult> ConfirmComment(int id)
        {
            Comment c = await _commentManager.FindAsync(id);
            c.CommentStatus = CommentStatus.Approved;
            await _commentManager.UpdateAsync(c);
            TempData["Message"] = "Yorumun onaylandı.";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RevorkComment(int id)
        {
            Comment c = await _commentManager.FindAsync(id);

            if (c == null)
            {
                // Yorum bulunamazsa, hata mesajı veya yönlendirme yapabilirsiniz
                return NotFound();
            }

            c.CommentStatus = CommentStatus.PendingApproval; // Onay durumunu geri al

            await _commentManager.UpdateAsync(c);

            // Yorumun onayını geri aldığına dair bir mesaj ekleyerek view'e yönlendirin
            TempData["Message"] = "Yorumun onayı geri alındı.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RejectComment(int id)
        {
            Comment c = await _commentManager.FindAsync(id);

            if (c == null)
            {
                // Yorum bulunamazsa, hata mesajı veya yönlendirme yapabilirsiniz
                return NotFound();
            }

            c.CommentStatus = CommentStatus.Rejected; // Yorumu reddet

            await _commentManager.UpdateAsync(c);

            // Yorumun reddedildiğine dair bir mesaj ekleyerek view'e yönlendirin
            TempData["Message"] = "Yorum reddedildi.";

            return RedirectToAction("Index");
        }



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
