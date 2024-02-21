using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class News : BaseEntity
    {

        public string Header { get; set; }
        public int SortNumber { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int AppUserID { get; set; }

        //Relational Properties
        public virtual ICollection<NewsCategory> NewsCategories { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
