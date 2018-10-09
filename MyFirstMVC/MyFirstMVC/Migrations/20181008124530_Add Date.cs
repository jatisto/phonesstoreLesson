using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class AddDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "AssemblyDate", "CategoryId", "CompanyId", "Name", "Price" },
                values: new object[] { 10, new DateTime(1999, 8, 20, 12, 50, 0, 0, DateTimeKind.Unspecified), 3, 8, "BlackBerry Passport 32GB (White)", 2699.9 });
        }
    }
}
