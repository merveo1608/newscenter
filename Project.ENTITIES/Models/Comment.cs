using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public CommentStatus CommentStatus { get; set; }
        public int AppUserID { get; set; }
        public int NewsID { get; set; }

        //relational proporties
       
        public virtual AppUser AppUser { get; set; }
        public virtual News News { get; set; }

    }
}
