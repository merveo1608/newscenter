using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mervex7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3af812a3-c709-4247-9168-db667cdf81de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c16a253-6dd9-476a-99ed-625c4e23367a", new DateTime(2024, 2, 17, 19, 47, 15, 470, DateTimeKind.Utc).AddTicks(9211), "AQAAAAIAAYagAAAAEDH6CR7PNM1ia4xBXOqmW/PHMxV23wHeBPY59eNZmneCBgddD4abmSkw+ykkwYzMQQ==", "2003f0cd-81ef-4a77-b0b7-10ab2380b948" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(336), "Non aut labore nostrum yazın nisi beğendim consectetur çünkü sevindi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(774), "Ama qui quae incidunt sit doğru gidecekmiş cesurca kapının voluptas." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(859), "Qui bundan consectetur dergi ut aliquid ona tv koştum salladı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(935), "Cesurca sayfası sevindi sit mıknatıslı makinesi doğru aliquid ipsum architecto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1004), "Ut kapının bundan sed makinesi gördüm un cezbelendi non ötekinden." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1129), "Ut lakin bilgisayarı architecto ad dolorem voluptatem consequatur çorba de." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1204), "Sayfası amet inventore dolor nemo eve patlıcan quasi gül çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1273), "Labore layıkıyla dolores duyulmamış suscipit eos ea orta iusto layıkıyla." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1345), "Sed dolore suscipit esse ama yaptı balıkhaneye sinema ut makinesi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 17, 19, 47, 15, 532, DateTimeKind.Utc).AddTicks(1413), "Domates doğru kalemi sayfası perferendis salladı cesurca için amet corporis." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "901daa42-172b-41ff-acec-b4bc82a6a2bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e0333db-ce3e-4480-9e41-8be0aa264db2", new DateTime(2024, 2, 17, 19, 36, 2, 907, DateTimeKind.Utc).AddTicks(8643), "AQAAAAIAAYagAAAAEAssXy6TjaxzKJEBgd+bf8CGtO0V9YKvGJYNpxbjWOkB0M4Yr2+AMzI+50vsvryiWA==", "033059dc-3842-48ad-9442-4dafdfc8ebcc" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(6772), "Ki sandalye commodi velit explicabo aperiam göze balıkhaneye eum beğendim." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7253), "Consequatur sinema kutusu quia düşünüyor explicabo voluptate explicabo amet camisi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7430), "Enim odit sokaklarda dolor sequi olduğu corporis exercitationem voluptatem doğru." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7503), "Doğru uzattı gül bundan qui inventore dolayı laboriosam ötekinden rem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7577), "Dolore quae quae consequatur için sevindi qui voluptatum eius ama." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7654), "Lambadaki ışık kapının sit tv ducimus consequatur consequatur et adresini." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7722), "Adanaya adresini ab karşıdakine umut ullam ea sit koştum qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7836), "Otobüs koyun iure adresini rem veritatis duyulmamış exercitationem kutusu quaerat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7900), "Accusantium eum adresini çobanın de lambadaki batarya et ea de." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7968), "Dolayı totam yapacakmış magnam çıktılar açılmadan nisi biber çünkü layıkıyla." });
        }
    }
}
