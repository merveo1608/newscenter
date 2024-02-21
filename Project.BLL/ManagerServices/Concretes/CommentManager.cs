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
    public class CommentManager : BaseManager<Comment>, ICommentManager
    {

        ICommentRepository _commRep;
        public CommentManager(ICommentRepository commRep) : base(commRep)
        {
            _commRep = commRep;
        }

    }
}
