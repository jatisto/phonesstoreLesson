using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class changedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { 1, 1, "Apple iPhone 7 256Gb Red", 74400.0 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "AssemblyDate", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[,]
                {
                    { 2, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 1, 1, "Apple iPhone 6S (Space Grey, 32GB)", 30500.0 },
                    { 3, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 1, 1, "Apple iPhone X (Space Grey, 256GB)", 99999.0 },
                    { 4, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 2, "Samsung On7 Pro (Gold)", 7990.0 },
                    { 5, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 2, "Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)", 13990.0 },
                    { 6, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 4, "Redmi 6 Pro (Black, 32GB)", 11499.0 },
                    { 7, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 4, "Redmi Y2 (Rose Gold, 32GB)", 9999.0 },
                    { 8, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 5, "LG Q6 (Black, 18:9 FullVision Display)", 11820.0 },
                    { 9, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 5, "LG V30+ (18:9 OLED FullVisionTM, 128GB, Black)", 34963.0 },
                    { 10, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 3, 8, "BlackBerry Passport 32GB (White)", 26999.0 },
                    { 11, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 6, "Huawei P20 Pro Blue (40MP Leica Triple Camera, 6GB+128GB)", 64999.0 },
                    { 12, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 3, "Nokia 6.1 (2018) (4GB + 64GB, Blue-Gold)", 15950.0 },
                    { 13, new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), 2, 7, "Sony Xperia R1 Plus Dual SIM (Black)", 11899.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { 2, 7, "Sony Xperia R1 Plus Dual SIM (Black)", 1189.9 });
        }
    }
}
