using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShop.Migrations
{
    public partial class SeedDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Price" },
                values: new object[] { "Category 1", "This is the description for Product 1", 10.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Price" },
                values: new object[] { "Category 2", "This is the description for Product 2", 19.989999999999998 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "Category 1", "This is the description for Product 3", "Product 3", 5.9900000000000002 },
                    { 4, "Category 3", "This is the description for Product 4", "Product 4", 15.99 },
                    { 5, "Category 2", "This is the description for Product 5", "Product 5", 12.49 },
                    { 6, "Category 1", "This is the description for Product 6", "Product 6", 9.9900000000000002 },
                    { 7, "Category 3", "This is the description for Product 7", "Product 7", 7.9900000000000002 },
                    { 8, "Category 2", "This is the description for Product 8", "Product 8", 14.99 },
                    { 9, "Category 1", "This is the description for Product 9", "Product 9", 11.99 },
                    { 10, "Category 3", "This is the description for Product 10", "Product 10", 8.9900000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Price" },
                values: new object[] { "Cat1", "Description 1", 10.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Price" },
                values: new object[] { "Cat2", "Description 2", 20.0 });
        }
    }
}
