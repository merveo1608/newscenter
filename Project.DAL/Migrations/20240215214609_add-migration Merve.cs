using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationMerve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1dab1e70-b15e-42f9-8f2c-cea3836856a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac5f30a9-57dc-46bc-bfef-e642f1be6d8a", new DateTime(2024, 2, 9, 17, 25, 55, 738, DateTimeKind.Utc).AddTicks(7049), "AQAAAAIAAYagAAAAEHcWVZvrPGw4pSqhCi99DUQfiVBZy2yKFtmkoT6aYJ14NHSDtoZd3X/2opsDthQ1gA==", "a1ec2418-8044-483a-a5de-f1e1b7b47fdf" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(1419), "Ut aut dicta de modi totam sit perferendis ve veniam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(1895), "Adresini göze numquam koşuyorlar qui dicta de voluptas gitti aspernatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2030), "Molestiae domates beğendim karşıdakine sayfası sıradanlıktan de salladı kulu çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2109), "De magnam quia ipsum ea qui non yazın aspernatur nihil." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2179), "Çorba architecto bilgiyasayarı voluptatem cesurca aperiam consequatur olduğu cezbelendi enim." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2607), "Ve bundan bilgisayarı sıradanlıktan çarpan consectetur modi exercitationem sokaklarda un." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2713), "Çarpan sıfat biber ut velit ışık masanın laboriosam suscipit adipisci." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2790), "Dolore telefonu türemiş gülüyorum sunt nesciunt olduğu sit veniam quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2869), "Commodi gül deleniti quis mıknatıslı perferendis hesap voluptatem quis quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2024, 2, 9, 17, 25, 55, 799, DateTimeKind.Utc).AddTicks(2935), "Amet ona filmini aut qui voluptatem de magnam nihil lambadaki." });
        }
    }
}
