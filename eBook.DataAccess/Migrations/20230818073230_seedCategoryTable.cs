using Microsoft.EntityFrameworkCore.Migrations;
using eBook.DataAccess;
#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eBooksWeb.Migrations
{
    /// <inheritdoc />
    public partial class seedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Scifi" },
                    { 3, 3, "Horror" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
