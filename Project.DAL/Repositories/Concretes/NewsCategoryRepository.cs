using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class NewsCategoryRepository : BaseRepository<NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(MyContext db) : base(db)
        {

        }

    }
}
