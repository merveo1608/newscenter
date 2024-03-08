using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mervex10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ac025f83-fe67-4cbe-be99-35530cb49574");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c3e6430-dabb-4b11-922c-41c40d0d1e97", new DateTime(2024, 3, 7, 18, 19, 30, 680, DateTimeKind.Utc).AddTicks(9180), "AQAAAAIAAYagAAAAEK9/vApyvF5F3wt8qTDRGIuKf7wbSpy4AktYa5Cr1BmGyzlP0g1H9BeArOcEekgkFA==", "54fdd98e-15bd-4083-ab5d-0f95bf1e3db5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(5942), "Voluptatem odit değirmeni makinesi camisi magnam lakin eum amet batarya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6439), "Dicta için sarmal eve ut ışık gitti balıkhaneye düşünüyor voluptas." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6530), "Camisi layıkıyla magni aliquid layıkıyla gördüm deleniti çorba adresini iure." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6671), "Ullam bundan kulu ötekinden şafak sunt eos aliquid şafak ki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6744), "Non commodi modi qui sequi ipsum sit cezbelendi dicta umut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6825), "Filmini orta ekşili göze otobüs nemo yapacakmış adresini consequatur eius." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6896), "Koyun okuma qui reprehenderit enim praesentium et öyle aliquid oldular." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6966), "Minima reprehenderit sıradanlıktan iure adipisci beğendim enim sıfat veritatis quaerat." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(7063), "Odit telefonu biber quam dolores teldeki aliquid bundan quis masaya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(7131), "Consectetur koştum ea sokaklarda yapacakmış doloremque nostrum nostrum adresini aliquam." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9265), "Dergi gidecekmiş aut odit sandalye masaya odit göze bahar quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 11, 35, 233, DateTimeKind.Utc).AddTicks(9334), "Dolores bilgiyasayarı layıkıyla nihil ipsam ullam aliquam beatae voluptatem ki." });

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
    }
}
