using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "BoardGames",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 1,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 60.0);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 5,
                column: "Price",
                value: 60.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "BoardGames");
        }
    }
}
