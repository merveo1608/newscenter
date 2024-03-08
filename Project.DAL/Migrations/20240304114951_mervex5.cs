using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mervex5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e0305a6d-96f9-4969-802e-8b33187b3ea1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "234b502d-baaf-4587-b864-52d0d2d957cf", new DateTime(2024, 3, 4, 11, 49, 51, 78, DateTimeKind.Utc).AddTicks(772), "AQAAAAIAAYagAAAAEI1Suh4MiYR56TOJEVYGrIvESeYTE6IKPCFgc/iKWod6c9STZmCrStZb52Rqgly9GQ==", "cb477f04-2f41-45be-a72f-dc4759beb45b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(3646), "Yaptı sıla fugit beatae qui et beatae nesciunt bundan doğru." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(4155), "Quam ona kalemi bilgisayarı ekşili kulu ipsum consequuntur incidunt voluptas." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(4243), "Deleniti voluptatem layıkıyla umut değirmeni reprehenderit deleniti ratione salladı velit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(4317), "Çünkü perferendis gördüm illo ut quaerat sıradanlıktan ona non sayfası." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(4915), "Quia ullam lambadaki accusantium aut sokaklarda öyle quia inventore dolayı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(5010), "Beğendim amet adanaya nihil alias veritatis quia non doğru göze." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(5081), "Ducimus et laboriosam doğru sit şafak yazın nihil voluptate sıfat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(5150), "Ipsam autem aspernatur voluptatem enim illo masaya dicta voluptatem kulu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(5272), "Gazete oldular sandalye beatae veniam sokaklarda in exercitationem nesciunt koyun." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(5339), "Gidecekmiş adanaya otobüs tv tempora ex quia ona veritatis iure." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ec677ac8-c80b-44c3-ba56-bdfa2ae06b2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c574b5e8-068c-4779-8e38-d9c9715fe953", new DateTime(2024, 2, 28, 20, 25, 42, 750, DateTimeKind.Utc).AddTicks(8244), "AQAAAAIAAYagAAAAENzU8Ogql0SNSH8RY3nXzf9+MP3CNvy0D4BhSmrEKpgqovgnnVBoiNrshT3qCvbrcA==", "9e016880-3f41-4335-8164-af0599d39fe1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(3643), "Dışarı blanditiis amet bilgisayarı magni totam çakıl ipsa çakıl masaya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4062), "Dergi quaerat ipsum voluptatem enim ekşili öyle patlıcan magnam doloremque." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4216), "Lambadaki gül bilgiyasayarı çobanın dergi lakin totam masanın voluptas yapacakmış." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4289), "Et ama odit batarya vitae ratione velit explicabo perferendis iure." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4366), "Ekşili tempora umut quia voluptate numquam quae in nesciunt ipsum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4439), "Illo aut umut reprehenderit cesurca exercitationem consectetur velit dışarı türemiş." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4599), "Accusantium değirmeni voluptatem aperiam modi dignissimos autem domates ötekinden voluptas." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4672), "Praesentium ut laudantium odio dolore esse ötekinden gül praesentium enim." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4738), "Magni ullam sandalye sinema quae çıktılar sandalye çıktılar de telefonu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4804), "Accusantium quis kutusu telefonu molestiae corporis mutlu ratione deleniti sokaklarda." });
        }
    }
}
