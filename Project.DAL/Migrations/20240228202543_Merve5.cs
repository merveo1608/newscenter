using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Merve5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kod",
                table: "Categories",
                newName: "Code");

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
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4738), "Magni ullam sandalye sinema quae çıktılar sandalye çıktılar de telefonu." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 2, 28, 20, 25, 42, 811, DateTimeKind.Utc).AddTicks(4804), "Accusantium quis kutusu telefonu molestiae corporis mutlu ratione deleniti sokaklarda." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Categories",
                newName: "Kod");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7f8b1621-a3a4-4488-85e7-e1c846b85cde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "778f4e0f-ce36-4790-b5ac-7f6bc793579d", new DateTime(2024, 2, 28, 10, 54, 33, 699, DateTimeKind.Utc).AddTicks(492), "AQAAAAIAAYagAAAAEBU8vj1KeLV2gtlR+imXMWREiWy9m1X8paoFs2uSakC6+ovavnOIS46Z0NKE8OCDKA==", "b00e611d-6b85-495d-9aa3-593afa518ef8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7165), "Veritatis ipsam biber voluptatem ötekinden gitti teldeki deleniti quia mıknatıslı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7641), "Sit dergi incidunt esse aut consequatur praesentium yaptı sit hesap." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7784), "Bahar ipsam ona ut eve quaerat voluptatem değirmeni aliquam beatae." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7862), "Mıknatıslı ducimus koşuyorlar kalemi koşuyorlar quia sevindi orta ışık sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7934), "Ratione kulu kulu inventore tempora aut düşünüyor değirmeni laudantium sıla." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8015), "Ötekinden ea masaya aut voluptatem okuma camisi praesentium incidunt çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8437), "Bahar quasi filmini explicabo fugit sinema bilgisayarı öyle gülüyorum aut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8548), "Patlıcan mutlu laboriosam sokaklarda nihil açılmadan velit camisi explicabo göze." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8617), "Orta sokaklarda consequatur de veniam odit deleniti sevindi consequatur değerli." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8682), "Suscipit deleniti öyle aperiam sokaklarda numquam nihil hesap camisi molestiae." });
        }
    }
}
