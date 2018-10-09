using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class Phones1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssemblyDate", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 7, "Sony Xperia R1 Plus Dual SIM (Black)", 1189.9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssemblyDate", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 1, 1, "Apple iPhone 7 256Gb Red", 744.0 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "AssemblyDate", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[,]
                {
                    { 2, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 1, 1, "Apple iPhone 6S (Space Grey, 32GB)", 305.0 },
                    { 3, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 1, 1, "Apple iPhone X (Space Grey, 256GB)", 999.99 },
                    { 4, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 2, "Samsung On7 Pro (Gold)", 799.0 },
                    { 5, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 2, "Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)", 1399.0 },
                    { 6, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 4, "Redmi 6 Pro (Black, 32GB)", 1149.9 },
                    { 7, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 4, "Redmi Y2 (Rose Gold, 32GB)", 999.9 },
                    { 8, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 5, "LG Q6 (Black, 18:9 FullVision Display)", 1182.0 },
                    { 9, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 5, "LG V30+ (18:9 OLED FullVisionTM, 128GB, Black)", 3496.3 },
                    { 10, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 3, 8, "BlackBerry Passport 32GB (White)", 2699.9 },
                    { 11, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 6, "Huawei P20 Pro Blue (40MP Leica Triple Camera, 6GB+128GB)", 6499.9 },
                    { 12, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 3, "Nokia 6.1 (2018) (4GB + 64GB, Blue-Gold)", 1595.0 },
                    { 13, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 2, 7, "Sony Xperia R1 Plus Dual SIM (Black)", 1189.9 }
                });
        }
    }
}
