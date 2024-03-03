using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class merve4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kod",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Toys", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7165), "Veritatis ipsam biber voluptatem ötekinden gitti teldeki deleniti quia mıknatıslı.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Grocery", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7641), "Sit dergi incidunt esse aut consequatur praesentium yaptı sit hesap.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Tools", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7784), "Bahar ipsam ona ut eve quaerat voluptatem değirmeni aliquam beatae.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Baby", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7862), "Mıknatıslı ducimus koşuyorlar kalemi koşuyorlar quia sevindi orta ışık sit.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Movies", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(7934), "Ratione kulu kulu inventore tempora aut düşünüyor değirmeni laudantium sıla.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Home", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8015), "Ötekinden ea masaya aut voluptatem okuma camisi praesentium incidunt çünkü.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Health", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8437), "Bahar quasi filmini explicabo fugit sinema bilgisayarı öyle gülüyorum aut.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Computers", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8548), "Patlıcan mutlu laboriosam sokaklarda nihil açılmadan velit camisi explicabo göze.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Baby", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8617), "Orta sokaklarda consequatur de veniam odit deleniti sevindi consequatur değerli.", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "Kod" },
                values: new object[] { "Sports", new DateTime(2024, 2, 28, 10, 54, 33, 760, DateTimeKind.Utc).AddTicks(8682), "Suscipit deleniti öyle aperiam sokaklarda numquam nihil hesap camisi molestiae.", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kod",
                table: "Categories");

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
    }
}
