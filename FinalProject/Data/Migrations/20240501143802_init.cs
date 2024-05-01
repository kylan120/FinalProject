using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "ID", "Company", "Image", "Name", "Players", "Price" },
                values: new object[] { 6, "adlhgl;g", "skyrim.jpg", "d;ljkdghkl", 2, 20.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
