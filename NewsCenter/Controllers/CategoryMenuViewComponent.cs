using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.ENTITIES.Models;

namespace NewsCenter.Controllers
{

    //websitenin anasayfasındaki header alanında bulunan haber categorilerini veritabnından çekip göstermek için bu component kullanıldı. Layoutta gösterileceği için özel compenent olarak geliştirldi.
    public class CategoryMenuViewComponent : ViewComponent
    {
       private readonly ICategoryManager _categoryManager;

        public CategoryMenuViewComponent(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IViewComponentResult Invoke()
        {
           List<Category> c = _categoryManager.GetAll();
            return View(c);
        }
    }
}
