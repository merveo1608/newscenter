using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class NewsCategory : BaseEntity
    {
        public int CategoryID { get; set; }
        public int NewsID { get; set; }

        //Relational Proporties
        public virtual Category Category { get; set; }
        public virtual News New { get; set; }

    }
}
