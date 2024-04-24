using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class addboardgames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "ID", "Company", "Name", "Players" },
                values: new object[,]
                {
                    { 1, "Hasbro", "Monoply", 8 },
                    { 2, "Bethesda", "Fallout", 8 },
                    { 3, "Klaus Teuber", "Settlers of Catan", 4 },
                    { 4, "Hasbro", "Sorry", 4 },
                    { 5, "Bethesda", "Elder Scrolls: Skyrim", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
