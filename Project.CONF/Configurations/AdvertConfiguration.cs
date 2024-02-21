using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class AdvertConfiguration : BaseConfiguration<Advert>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            base.Configure(builder);
        }
    }
}
