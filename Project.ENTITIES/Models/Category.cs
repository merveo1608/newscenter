﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public int SortNumber { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual ICollection<News>? News { get; set; }
    }
}
