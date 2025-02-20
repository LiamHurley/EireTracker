using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedCleanSheets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CleanSheet",
                table: "Performances",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "CleanSheets",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CleanSheet",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "CleanSheets",
                table: "OverallStats");
        }
    }
}
