using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class OverallStatsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Captain",
                table: "Performances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Substitute",
                table: "Performances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "OverallStats",
                columns: table => new
                {
                    OverallStatsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchesPlayed = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SavedShotsFromInsideTheBox = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Saves = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Punches = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalKeeperSweeper = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AccurateKeeperSweeper = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ErrorLeadToAShot = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalClearance = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AerialLost = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AerialWon = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DuelLost = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DuelWon = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    InterceptionWon = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalTackle = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OutfielderBlock = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalPass = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AccuratePass = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalLongBalls = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AccurateLongBalls = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TotalCross = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AccurateCross = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BigChanceCreated = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    PossessionLostCtrl = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KeyPass = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Goals = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BigChanceMissed = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ShotOffTarget = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OnTargetScoringAttempt = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BlockedScoringAttempt = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    WasFouled = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Fouls = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    MinutesPlayed = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Touches = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Rating = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TotalOffside = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Substitute = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Captain = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallStats", x => x.OverallStatsId);
                    table.ForeignKey(
                        name: "FK_OverallStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OverallStats_PlayerId",
                table: "OverallStats",
                column: "PlayerId",
                unique: true,
                filter: "[PlayerId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OverallStats");

            migrationBuilder.DropColumn(
                name: "Captain",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "Substitute",
                table: "Performances");
        }
    }
}
