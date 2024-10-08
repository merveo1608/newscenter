﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DAL.ContextClasses;

#nullable disable

namespace Project.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240228105434_merve4")]
    partial class merve4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "7f8b1621-a3a4-4488-85e7-e1c846b85cde",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Advert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WebsiteURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "778f4e0f-ce36-4790-b5ac-7f6bc793579d",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 699, DateTimeKind.Utc).AddTicks(492),
                            Email = "merveodabas1608@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MERVEODABAS1608@GMAIL.COM",
                            NormalizedUserName = "MERVE123",
                            PasswordHash = "AQAAAAIAAYagAAAAEBU8vj1KeLV2gtlR+imXMWREiWy9m1X8paoFs2uSakC6+ovavnOIS46Z0NKE8OCDKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b00e611d-6b85-495d-9aa3-593afa518ef8",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "merve123"
                        });
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SortNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Toys",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7165),
                            Description = "Veritatis ipsam biber voluptatem ötekinden gitti teldeki deleniti quia mıknatıslı.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Grocery",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7641),
                            Description = "Sit dergi incidunt esse aut consequatur praesentium yaptı sit hesap.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Tools",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7784),
                            Description = "Bahar ipsam ona ut eve quaerat voluptatem değirmeni aliquam beatae.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Baby",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7862),
                            Description = "Mıknatıslı ducimus koşuyorlar kalemi koşuyorlar quia sevindi orta ışık sit.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Movies",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7934),
                            Description = "Ratione kulu kulu inventore tempora aut düşünüyor değirmeni laudantium sıla.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8015),
                            Description = "Ötekinden ea masaya aut voluptatem okuma camisi praesentium incidunt çünkü.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Health",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8437),
                            Description = "Bahar quasi filmini explicabo fugit sinema bilgisayarı öyle gülüyorum aut.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Computers",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8548),
                            Description = "Patlıcan mutlu laboriosam sokaklarda nihil açılmadan velit camisi explicabo göze.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Baby",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8617),
                            Description = "Orta sokaklarda consequatur de veniam odit deleniti sevindi consequatur değerli.",
                            SortNumber = 0,
                            Status = 1
                        },
                        new
                        {
                            ID = 10,
                            CategoryName = "Sports",
                            CreatedDate = new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8682),
                            Description = "Suscipit deleniti öyle aperiam sokaklarda numquam nihil hesap camisi molestiae.",
                            SortNumber = 0,
                            Status = 1
                        });
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NewsID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("NewsID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int?>("AppUserProfileID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Subject")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("AppUserProfileID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SortNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("CategoryID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithOne("Profile")
                        .HasForeignKey("Project.ENTITIES.Models.AppUserProfile", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Comment", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("News");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Contact", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.AppUserProfile", null)
                        .WithMany("Contacts")
                        .HasForeignKey("AppUserProfileID");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.News", b =>
                {
                    b.HasOne("Project.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("News")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.ENTITIES.Models.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("News");

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("Project.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.Category", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("Project.ENTITIES.Models.News", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
