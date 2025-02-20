using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddedMatchDetailsToPerformanceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwayScore",
                table: "Performances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AwayTeam",
                table: "Performances",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAway",
                table: "Performances",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeScore",
                table: "Performances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeTeam",
                table: "Performances",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayScore",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AwayTeam",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "HomeAway",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "HomeScore",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "HomeTeam",
                table: "Performances");
        }
    }
}
