using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class NewsConfiguration :BaseConfiguration<News>
    {
        public override void Configure(EntityTypeBuilder<News> builder)
        {
            base.Configure(builder);
        }
    }
}
