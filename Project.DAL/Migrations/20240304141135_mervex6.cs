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
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "923d6df2-1434-4265-85df-b81900219789");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53150554-e456-489c-ab2d-ab176facb47a", new DateTime(2024, 3, 4, 14, 11, 35, 173, DateTimeKind.Utc).AddTicks(873), "AQAAAAIAAYagAAAAEE/smykjM/vMKfBp2gR9MswDwdoygLY42Qh25sI2Shk4aMNOQ7RxNr4+akcIPUIjpw==", "4fdbe8f8-a6ac-4696-9aed-f2d241092fa0" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(8711), "Bundan adipisci in sed eius eos praesentium dolor kutusu architecto." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9103), "Aut camisi koşuyorlar domates sed rem filmini sit çorba kapının." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9184), "Sıla laboriosam oldular voluptas ötekinden sokaklarda çıktılar ipsum okuma öyle." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9265), "Dergi gidecekmiş aut odit sandalye masaya odit göze bahar quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9334), "Dolores bilgiyasayarı layıkıyla nihil ipsam ullam aliquam beatae voluptatem ki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9434), "Gitti sequi explicabo velit bahar ut amet adresini praesentium dicta." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9506), "Nihil türemiş totam neque makinesi et minima ekşili consequatur illo." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9575), "Accusantium voluptatem filmini explicabo nisi sunt odio oldular qui gördüm." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9642), "Sandalye göze sequi masanın odit çünkü gülüyorum magni eve consectetur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9709), "Nemo voluptatem odit quam yaptı tv vitae sit neque cesurca." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 3, 4, 11, 49, 51, 138, DateTimeKind.Utc).AddTicks(4317), "Çünkü perferendis gördüm illo ut quaerat sıradanlıktan ona non sayfası." });

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
    }
}
