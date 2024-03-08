using Microsoft.AspNetCore.Mvc;
using NewsCenter.Models;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System.CodeDom;
using System.Diagnostics;

namespace NewsCenter.Controllers
{
    public class NewsDetailController : Controller
    {
        private readonly ILogger<NewsDetailController> _logger;
        private readonly INewsManager _newsManager;
        private readonly ICommentManager _commentManager;
       
        public NewsDetailController(INewsManager newsManager, ICommentManager commentManager)
        {
            _newsManager = newsManager;
            _commentManager = commentManager;
        }
        public async Task<IActionResult> Index(int id)
        {
            //haber için
            News n = await _newsManager.FindAsync(id);
            ViewBag.NewsDetail = n;

            //yeni yorum modeli
            Comment cm = new Comment();
            cm.NewsID = id;

            //Habere ait tüm yorumlar
            List<Comment> commentList = _commentManager.Where(x=>x.NewsID == id && x.CommentStatus == CommentStatus.Approved).ToList() ;
            ViewBag.Comments = commentList;
            return View(cm);
        }


        [HttpPost]
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            comment.AppUserID = 1;
            comment.CommentStatus = CommentStatus.PendingApproval;
            await _commentManager.AddAsync(comment);
            return RedirectToAction("Index", new {ID = comment.NewsID});
        }

    }
}
