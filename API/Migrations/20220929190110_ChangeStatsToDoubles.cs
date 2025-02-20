using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class ChangeStatsToDoubles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "WasFouled",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Touches",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTackle",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOffside",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalLongBalls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalKeeperSweeper",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCross",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalClearance",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "ShotOffTarget",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Saves",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "SavedShotsFromInsideTheBox",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Punches",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "PossessionLostCtrl",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "OutfielderBlock",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "OnTargetScoringAttempt",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "MinutesPlayed",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "KeyPass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "InterceptionWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Goals",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "GoalAssist",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Fouls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "ErrorLeadToAShot",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "DuelWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "DuelLost",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BlockedScoringAttempt",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceMissed",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceCreated",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AerialWon",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AerialLost",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccuratePass",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateLongBalls",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateKeeperSweeper",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateCross",
                table: "Performances",
                type: "float",
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "WasFouled",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Touches",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalTackle",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOffside",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalLongBalls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalKeeperSweeper",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCross",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "TotalClearance",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Substitute",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "ShotOffTarget",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Saves",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "SavedShotsFromInsideTheBox",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Punches",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "PossessionLostCtrl",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "OutfielderBlock",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "OnTargetScoringAttempt",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "MinutesPlayed",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "KeyPass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "InterceptionWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Goals",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "GoalAssist",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Fouls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "ErrorLeadToAShot",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "DuelWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "DuelLost",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Captain",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BlockedScoringAttempt",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceMissed",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "BigChanceCreated",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AerialWon",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AerialLost",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccuratePass",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateLongBalls",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateKeeperSweeper",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "AccurateCross",
                table: "OverallStats",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WasFouled",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Touches",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalTackle",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPass",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalOffside",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalLongBalls",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalKeeperSweeper",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalCross",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalClearance",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "ShotOffTarget",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Saves",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "SavedShotsFromInsideTheBox",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Punches",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "PossessionLostCtrl",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "OutfielderBlock",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "OnTargetScoringAttempt",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "MinutesPlayed",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "KeyPass",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "InterceptionWon",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Goals",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "GoalAssist",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Fouls",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "ErrorLeadToAShot",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "DuelWon",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "DuelLost",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BlockedScoringAttempt",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BigChanceMissed",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BigChanceCreated",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AerialWon",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AerialLost",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccuratePass",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateLongBalls",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateKeeperSweeper",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateCross",
                table: "Performances",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "WasFouled",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Touches",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalTackle",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPass",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalOffside",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalLongBalls",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalKeeperSweeper",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalCross",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "TotalClearance",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Substitute",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "ShotOffTarget",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Saves",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "SavedShotsFromInsideTheBox",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Punches",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "PossessionLostCtrl",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "OutfielderBlock",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "OnTargetScoringAttempt",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "MinutesPlayed",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "KeyPass",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "InterceptionWon",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Goals",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "GoalAssist",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Fouls",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "ErrorLeadToAShot",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "DuelWon",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "DuelLost",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Captain",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BlockedScoringAttempt",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BigChanceMissed",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "BigChanceCreated",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AerialWon",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AerialLost",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccuratePass",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateLongBalls",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateKeeperSweeper",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "AccurateCross",
                table: "OverallStats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);
        }
    }
}
