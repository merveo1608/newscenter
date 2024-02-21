using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public  class NewsCategoryConfiguration : BaseConfiguration<NewsCategory>
    {
        public override void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.NewsID,
                x.CategoryID
            });
           
        }
    }
}
