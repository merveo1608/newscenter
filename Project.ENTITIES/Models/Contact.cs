using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Contact : BaseEntity
    {
        public Subject Subject { get; set; }
        public string Description { get; set; }
        public int AppUserID { get; set; }

        //Relational Properties 
        public virtual AppUser AppUser { get; set; }
        
    }
}
