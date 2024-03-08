using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mervex11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentStatus",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ed68dbf5-8bc8-4b78-85a7-2fdd8ee37c37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a9d6dc-82b4-47bb-ba12-782d60944425", new DateTime(2024, 3, 8, 8, 12, 58, 116, DateTimeKind.Utc).AddTicks(1486), "AQAAAAIAAYagAAAAEG3aw4ekncOrqF+ki1TzKtT156GyTTk98LX1EHJCcOC1+WuCewVDpGSahIhFzn/5NQ==", "397ffa1a-d6e9-4ce0-b979-c2da97bf8a48" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(7479), "Makinesi adanaya mıknatıslı gazete ki voluptatem veritatis velit kutusu sıradanlıktan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(7996), "Cesurca commodi un reprehenderit velit karşıdakine ekşili adanaya architecto quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8085), "Çobanın hesap corporis quia dergi consequatur ea odio sit veritatis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8259), "Vel de ullam koşuyorlar modi telefonu quasi eum ona un." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8339), "Labore enim dolores layıkıyla fugit quia et rem suscipit eve." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8422), "Dolores kutusu yazın ışık biber çıktılar quis aliquam eve sunt." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8496), "Enim exercitationem gülüyorum et un aspernatur kutusu deleniti suscipit qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8597), "Bundan eve kutusu nemo kalemi quis neque neque sarmal masanın." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8666), "Sit commodi blanditiis ipsam hesap voluptas nihil quia tv ötekinden." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 3, 8, 8, 12, 58, 177, DateTimeKind.Utc).AddTicks(8737), "Koşuyorlar ratione voluptatum ab ışık türemiş velit masaya voluptatem hesap." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentStatus",
                table: "Comments");

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
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2024, 3, 7, 18, 19, 30, 743, DateTimeKind.Utc).AddTicks(6744), "Non commodi modi qui sequi ipsum sit cezbelendi dicta umut." });

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
    }
}
