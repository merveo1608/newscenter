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
    internal class AdvertManager : BaseManager<Advert>, IAdvertManager
    {
        IAdvertRepository _adRep;
        public AdvertManager(IAdvertRepository adRep) : base(adRep)
        {
            _adRep = adRep;
        }

    }
}
