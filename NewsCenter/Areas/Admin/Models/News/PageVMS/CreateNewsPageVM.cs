using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Models
{
    public class CreateNewsPageVM
    {
        //News Controller için oluşturulmuştur.

        public List<Category> Categories { get; set; }
        public News News { get; set; }

    }
}
