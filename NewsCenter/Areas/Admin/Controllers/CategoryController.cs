using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            ViewBag.activeMenu = "Category";

            return View(_categoryManager.GetAll());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            await _categoryManager.AddAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryManager.Delete(await _categoryManager.FindAsync(id));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DestroyCategory(int id)
        {

            try
            {
                TempData["Message"] = _categoryManager.Destroy(await _categoryManager.FindAsync(id));

            }

            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
            {
                // Foreign key ihlaliyle ilgili özel işlem
                TempData["Message"] = "Bu kategoriyi silemezsiniz, çünkü kategoriye ait haberler bulunmaktadır.";
            }
            catch (Exception ex)
            {
                // Diğer tüm hatalar için genel bir yakalama bloğu
                TempData["Message"] = "Kategori silme işlemi sırasında bir hata oluştu: " + ex.Message;

            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            return View(await _categoryManager.FindAsync(id));

        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            await _categoryManager.UpdateAsync(model);
            return RedirectToAction("Index");

        }

    }

}
