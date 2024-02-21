using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class UserRoleDataSeedExtension
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            IdentityRole<int> appRole = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() //sistemimde yeni bir guid oluşmasını sağlamak için ekledim.guid benzersiz bir tanımlayıcı anlamına gelir.
            };

            modelBuilder.Entity<IdentityRole<int>>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>(); //IdentityFrameworkten gelir.Şifrelerin hashlenmesi ve doğrulanması için kullanılır.

            AppUser user = new()
            {
                Id = 1,
                UserName = "merve123",
                Email = "merveodabas1608@gmail.com",
                NormalizedEmail = "MERVEODABAS1608@GMAIL.COM",
                NormalizedUserName = "MERVE123",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "merve123")

            };

            modelBuilder.Entity<AppUser>().HasData(user);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = appRole.Id,
                UserId = user.Id
            });
        }
    }
}
