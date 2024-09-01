using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly INewsManager _newsManager;


        public DataController(INewsManager newsManager)
        {
            _newsManager = newsManager;
           
        }
        // GET: api/data/news
        [HttpGet("news")]
        public async Task<ActionResult> GetNews()
        {
            var newsList = _newsManager.GetAll().Select(n => new
            {
               n.Header,
                n.Description
            }).ToList(); 
            return Ok(newsList); 
        }
    }
}
