using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class ContactManager :BaseManager<Contact>, IContactManager
    {
        IContactRepository _conRep;
        public ContactManager(IContactRepository conRep):base(conRep) 
        {
            _conRep = conRep;
        }
    }
}
