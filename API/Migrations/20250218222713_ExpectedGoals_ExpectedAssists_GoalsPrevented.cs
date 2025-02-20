using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class ExpectedGoals_ExpectedAssists_GoalsPrevented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedAssists",
                table: "Performances",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedGoals",
                table: "Performances",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GoalsPrevented",
                table: "Performances",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedAssists",
                table: "OverallStats",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedGoals",
                table: "OverallStats",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GoalsPrevented",
                table: "OverallStats",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedAssists",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "ExpectedGoals",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "GoalsPrevented",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "ExpectedAssists",
                table: "OverallStats");

            migrationBuilder.DropColumn(
                name: "ExpectedGoals",
                table: "OverallStats");

            migrationBuilder.DropColumn(
                name: "GoalsPrevented",
                table: "OverallStats");
        }
    }
}
