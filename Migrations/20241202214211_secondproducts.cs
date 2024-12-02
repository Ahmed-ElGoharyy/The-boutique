using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace trefle888.Migrations
{
    /// <inheritdoc />
    public partial class secondproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "resources/suit1.jpg", "REGULAR FIT TRAVELER BLAZER", 6599.0 },
                    { 2, "resources/suit2.jpg", "REGULAR FIT PREMIUM WOOL DOUBLE BREASTED BLAZER", 9740.0 },
                    { 3, "resources/suit3.jpg", "REGULAR FIT PREMIUM WOOL BLAZER", 8250.0 },
                    { 4, "~/resources/suit4.jpg", "SLIM FIT TRAVELER BlAZER", 5250.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
