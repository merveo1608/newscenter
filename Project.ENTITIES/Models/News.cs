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
        public DateTime PublishDate { get; set; }
        public string ImageURL { get; set; }
        public int AppUserID { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
