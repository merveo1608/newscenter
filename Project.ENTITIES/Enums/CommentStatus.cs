using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Enums
{
    public enum CommentStatus
    {
        PendingApproval = 1, // Onay Bekliyor
        Approved = 2,       // Onaylandı
        Rejected = 3        // Reddedildi
    }
}
