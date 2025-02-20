using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class OverallStatsIdDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Players",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Players",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Club",
                table: "Players",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "WasFouled",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Touches",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTackle",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPass",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOffside",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalLongBalls",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalKeeperSweeper",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCross",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalClearance",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<bool>(
                name: "Substitute",
                table: "Performances",
                type: "tinyint(1)",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: 0ul);

            migrationBuilder.AlterColumn<double>(
                name: "ShotOffTarget",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Saves",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "SavedShotsFromInsideTheBox",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Punches",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "PossessionLostCtrl",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "OutfielderBlock",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "OnTargetScoringAttempt",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "MinutesPlayed",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "MatchDate",
                table: "Performances",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "KeyPass",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "InterceptionWon",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "HomeTeam",
                table: "Performances",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAway",
                table: "Performances",
                type: "varchar(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "Goals",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "GoalAssist",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Fouls",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "ErrorLeadToAShot",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "DuelWon",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "DuelLost",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<bool>(
                name: "CleanSheet",
                table: "Performances",
                type: "tinyint(1)",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: 0ul);

            migrationBuilder.AlterColumn<bool>(
                name: "Captain",
                table: "Performances",
                type: "tinyint(1)",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: 0ul);

            migrationBuilder.AlterColumn<double>(
                name: "BlockedScoringAttempt",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceMissed",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceCreated",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "AwayTeam",
                table: "Performances",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "AerialWon",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AerialLost",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccuratePass",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateLongBalls",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateKeeperSweeper",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateCross",
                table: "Performances",
                type: "double",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "WasFouled",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Touches",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTackle",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalShotsTaken",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPass",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOffside",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalLongBalls",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalKeeperSweeper",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalDuels",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCross",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalClearance",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "TotalAerialDuels",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Substitute",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "ShotOffTarget",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Saves",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "SavedShotsFromInsideTheBox",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Punches",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "PossessionLostCtrl",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "OutfielderBlock",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "OnTargetScoringAttempt",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "MinutesPlayed",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "KeyPass",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "InterceptionWon",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Goals",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "GoalAssist",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Fouls",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "ErrorLeadToAShot",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "DuelWon",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "DuelLost",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "CleanSheets",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "Captain",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "BlockedScoringAttempt",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceMissed",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceCreated",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AverageRating",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AerialWon",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AerialLost",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccuratePass",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateLongBalls",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateKeeperSweeper",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateCross",
                table: "OverallStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "OverallStatsId",
                table: "OverallStats",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.CreateIndex(
            //    name: "IX_OverallStats_PlayerId",
            //    table: "OverallStats",
            //    column: "PlayerId",
            //    unique: true,
            //    filter: "[PlayerId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Players",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Players",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Club",
                table: "Players",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "WasFouled",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Touches",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalTackle",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalPass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalOffside",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalLongBalls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalKeeperSweeper",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalCross",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalClearance",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<ulong>(
                name: "Substitute",
                table: "Performances",
                type: "bit",
                nullable: true,
                defaultValue: 0ul,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<float>(
                name: "ShotOffTarget",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Saves",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "SavedShotsFromInsideTheBox",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Punches",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "PossessionLostCtrl",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "OutfielderBlock",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "OnTargetScoringAttempt",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "MinutesPlayed",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "MatchDate",
                table: "Performances",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "KeyPass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "InterceptionWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "HomeTeam",
                table: "Performances",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HomeAway",
                table: "Performances",
                type: "nvarchar(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "Goals",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "GoalAssist",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Fouls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "ErrorLeadToAShot",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "DuelWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "DuelLost",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<ulong>(
                name: "CleanSheet",
                table: "Performances",
                type: "bit",
                nullable: true,
                defaultValue: 0ul,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<ulong>(
                name: "Captain",
                table: "Performances",
                type: "bit",
                nullable: true,
                defaultValue: 0ul,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<float>(
                name: "BlockedScoringAttempt",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "BigChanceMissed",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "BigChanceCreated",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "AwayTeam",
                table: "Performances",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<float>(
                name: "AerialWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AerialLost",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccuratePass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateLongBalls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateKeeperSweeper",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateCross",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "WasFouled",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Touches",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalTackle",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalShotsTaken",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalPass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalOffside",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalLongBalls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalKeeperSweeper",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalDuels",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalCross",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalClearance",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "TotalAerialDuels",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Substitute",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "ShotOffTarget",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Saves",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "SavedShotsFromInsideTheBox",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Punches",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "PossessionLostCtrl",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "OutfielderBlock",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "OnTargetScoringAttempt",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "MinutesPlayed",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "KeyPass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "InterceptionWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Goals",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "GoalAssist",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Fouls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "ErrorLeadToAShot",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "DuelWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "DuelLost",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "CleanSheets",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "Captain",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "BlockedScoringAttempt",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "BigChanceMissed",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "BigChanceCreated",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AverageRating",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AerialWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AerialLost",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccuratePass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateLongBalls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateKeeperSweeper",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<float>(
                name: "AccurateCross",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "double",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "OverallStatsId",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_OverallStats_PlayerId",
                table: "OverallStats",
                column: "PlayerId",
                unique: true,
                filter: "[PlayerId] IS NOT NULL");
        }
    }
}
