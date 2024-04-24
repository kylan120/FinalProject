using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class imagesforgames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "monoply.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "fallout.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "settlers.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "sorry.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "skyrim.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "BoardGames");
        }
    }
}
