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
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(MyContext db) : base(db)
        {

        }
    }
    
}
