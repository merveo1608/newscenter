using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.CONF.Configurations;
using Project.DAL.Extensions;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppUserProfileConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new NewsCategoryConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AdvertConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            UserRoleDataSeedExtension.SeedUsers(builder);
            CategoryDataSeedExtension.SeedCategories(builder);
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Advert> Adverts { get; set; }

    }
}
