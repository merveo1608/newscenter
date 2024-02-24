using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class merve1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a4134c21-a2ac-42b3-a9d5-0581227f0631");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa190d66-cfb7-4ef7-82f3-f2826fd4d4af", new DateTime(2024, 2, 24, 9, 49, 35, 891, DateTimeKind.Utc).AddTicks(6817), "AQAAAAIAAYagAAAAECjfcqzxpLe96jMWpbKAal+83O8uZalSXg1KtHdSWCZCR+DHrNK5GkEwWWOH0xg5vQ==", "f4140841-b14d-4dc0-a137-a49b730cb9b9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(7625), "Bundan göze velit şafak sequi dışarı lambadaki makinesi consectetur çakıl." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(7968), "Hesap bahar ut dışarı sit voluptatem lambadaki aut eaque bilgisayarı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8140), "Beğendim dicta dolores aliquid sed adresini velit ex minima rem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8214), "Ki yazın dolor adipisci eaque consequuntur consequatur blanditiis mıknatıslı sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8290), "Sarmal iure masanın iure tempora sit fugit hesap çorba yaptı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8368), "Gitti eum layıkıyla camisi consequuntur qui ex sit makinesi ipsa." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8438), "Sayfası nihil bundan qui ea voluptate quis sunt perferendis ekşili." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8549), "Eve ut quia laboriosam ki göze tempora rem anlamsız nihil." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8618), "Ratione sit enim beatae consequuntur telefonu eaque çıktılar magnam okuma." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2024, 2, 24, 9, 49, 35, 951, DateTimeKind.Utc).AddTicks(8687), "Bilgisayarı balıkhaneye enim cesurca consequuntur patlıcan için koştum gidecekmiş masaya." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1d7015de-7a92-4482-a5c7-b0475d13cd2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d99a453b-dbd8-4a92-b0f5-593d5ac78fe7", new DateTime(2024, 2, 24, 9, 47, 58, 277, DateTimeKind.Utc).AddTicks(6723), "AQAAAAIAAYagAAAAEFZikpUi+3i70wML+3UhyXyqI5zdELpVNJd7SsuI+GU/msHgrZAOGkOg9dzNjOsb6w==", "ff54db78-70a6-4259-8ec8-a1628bab99ed" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(4511), "Dolayı lambadaki qui dolores nesciunt esse adresini kulu nesciunt voluptatem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(4829), "Qui çarpan de quis voluptatem praesentium bundan ipsum layıkıyla çıktılar." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(4914), "Dergi eve kapının çakıl biber quam dışarı gidecekmiş sıfat umut." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5072), "Ona açılmadan dışarı çakıl makinesi sunt qui aliquam aliquam deleniti." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5140), "Duyulmamış architecto ipsum ducimus dergi adanaya sevindi gördüm ki accusantium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5212), "Rem inventore consectetur nihil numquam quis camisi gül anlamsız dolorem." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5284), "Adanaya consequatur açılmadan et sokaklarda telefonu magnam de non minima." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5392), "Tv değerli ea ipsa lambadaki oldular odio olduğu yapacakmış et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5461), "Için dicta quam oldular ab reprehenderit türemiş dergi dergi odio." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 2, 24, 9, 47, 58, 337, DateTimeKind.Utc).AddTicks(5525), "Otobüs gazete aut biber dağılımı architecto de teldeki sit blanditiis." });
        }
    }
}
