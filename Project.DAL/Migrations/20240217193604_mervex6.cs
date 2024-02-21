using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mervex6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7253), "Consequatur sinema kutusu quia düşünüyor explicabo voluptate explicabo amet camisi." });

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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 2, 17, 19, 36, 2, 967, DateTimeKind.Utc).AddTicks(7968), "Dolayı totam yapacakmış magnam çıktılar açılmadan nisi biber çünkü layıkıyla." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8a8850bc-283b-4eec-a4b5-259fc6549216");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20f0bba-7363-4bf1-a330-c36c178cf803", new DateTime(2024, 2, 15, 21, 46, 8, 458, DateTimeKind.Utc).AddTicks(5024), "AQAAAAIAAYagAAAAEIAFGhcjMeVYbs7XQBY+HXalPQTDjR/dl3Mtr4jd9quCbVyQGoIwOfL2HIlQ+x3dpA==", "76c9b9f7-d3db-4a38-a012-5e271c95875c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(971), "Işık voluptatum explicabo dicta masanın alias voluptas lambadaki enim dolor." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(1959), "Consequatur bahar lambadaki nisi tempora veritatis dağılımı nemo consectetur koyun." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2063), "Bilgisayarı yazın gül beğendim quia dolayı dolores okuma ut hesap." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2140), "Consequatur layıkıyla cezbelendi veniam camisi vitae et de sunt velit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2213), "Ona iure et quia blanditiis et voluptatem oldular adresini gülüyorum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2323), "Ex alias vitae kutusu ea kulu minima esse nostrum bundan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2393), "Quia lambadaki için salladı oldular dolorem veritatis çıktılar ışık iusto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2460), "Sandalye makinesi ipsam kutusu quasi türemiş neque yaptı aperiam sed." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2531), "Consequuntur blanditiis aut kulu teldeki accusantium koyun ea balıkhaneye iusto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 2, 15, 21, 46, 8, 521, DateTimeKind.Utc).AddTicks(2684), "Quis açılmadan architecto magnam kulu doloremque sed şafak öyle ipsam." });
        }
    }
}
