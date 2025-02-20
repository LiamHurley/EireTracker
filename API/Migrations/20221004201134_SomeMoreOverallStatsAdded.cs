using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class SomeMoreOverallStatsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalAerialDuels",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalDuels",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalShotsTaken",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAerialDuels",
                table: "OverallStats");

            migrationBuilder.DropColumn(
                name: "TotalDuels",
                table: "OverallStats");

            migrationBuilder.DropColumn(
                name: "TotalShotsTaken",
                table: "OverallStats");
        }
    }
}
