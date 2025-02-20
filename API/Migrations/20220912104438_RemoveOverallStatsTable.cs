using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class RemoveOverallStatsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatsProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatsProfiles",
                columns: table => new
                {
                    StatsProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    AccurateCross = table.Column<int>(type: "int", nullable: true),
                    AccurateKeeperSweeper = table.Column<int>(type: "int", nullable: true),
                    AccurateLongBalls = table.Column<int>(type: "int", nullable: true),
                    AccuratePass = table.Column<int>(type: "int", nullable: true),
                    AerialLost = table.Column<int>(type: "int", nullable: true),
                    AerialWon = table.Column<int>(type: "int", nullable: true),
                    BigChanceCreated = table.Column<int>(type: "int", nullable: true),
                    BigChanceMissed = table.Column<int>(type: "int", nullable: true),
                    BlockedScoringAttempt = table.Column<int>(type: "int", nullable: true),
                    DuelLost = table.Column<int>(type: "int", nullable: true),
                    DuelWon = table.Column<int>(type: "int", nullable: true),
                    ErrorLeadToAShot = table.Column<int>(type: "int", nullable: true),
                    Fouls = table.Column<int>(type: "int", nullable: true),
                    Goals = table.Column<int>(type: "int", nullable: true),
                    InterceptionWon = table.Column<int>(type: "int", nullable: true),
                    KeyPass = table.Column<int>(type: "int", nullable: true),
                    MinutesPlayed = table.Column<int>(type: "int", nullable: true),
                    OnTargetScoringAttempt = table.Column<int>(type: "int", nullable: true),
                    OutfielderBlock = table.Column<int>(type: "int", nullable: true),
                    PossessionLostCtrl = table.Column<int>(type: "int", nullable: true),
                    Punches = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    SavedShotsFromInsideTheBox = table.Column<int>(type: "int", nullable: true),
                    Saves = table.Column<int>(type: "int", nullable: true),
                    ShotOffTarget = table.Column<int>(type: "int", nullable: true),
                    TotalClearance = table.Column<int>(type: "int", nullable: true),
                    TotalCross = table.Column<int>(type: "int", nullable: true),
                    TotalKeeperSweeper = table.Column<int>(type: "int", nullable: true),
                    TotalLongBalls = table.Column<int>(type: "int", nullable: true),
                    TotalOffside = table.Column<int>(type: "int", nullable: true),
                    TotalPass = table.Column<int>(type: "int", nullable: true),
                    TotalTackle = table.Column<int>(type: "int", nullable: true),
                    Touches = table.Column<int>(type: "int", nullable: true),
                    WasFouled = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsProfiles", x => x.StatsProfileId);
                    table.ForeignKey(
                        name: "FK_StatsProfiles_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatsProfiles_PlayerId",
                table: "StatsProfiles",
                column: "PlayerId",
                unique: true,
                filter: "[PlayerId] IS NOT NULL");
        }
    }
}
