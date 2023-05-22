using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShop.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "Description", "Name", "Price" },
                values: new object[] { 1, "Cat1", "Description 1", "Product 1", 10.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "Description", "Name", "Price" },
                values: new object[] { 2, "Cat2", "Description 2", "Product 2", 20.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
