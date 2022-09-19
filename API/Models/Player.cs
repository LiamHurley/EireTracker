namespace API.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        public OverallStats OverallStats { get; set; }
        public List<Performance>? Performances { get; set; }

        public void UpdateOverallStats(Performance performance)
        {
            OverallStats.MatchesPlayed++;
            OverallStats.AccurateCross += UpdateIntStat(performance.AccurateCross);
            OverallStats.AccurateKeeperSweeper += UpdateIntStat(performance.AccurateKeeperSweeper);
            OverallStats.AccurateLongBalls += UpdateIntStat(performance.AccurateLongBalls);
            OverallStats.AerialLost += UpdateIntStat(performance.AerialLost);
            OverallStats.AccuratePass += UpdateIntStat(performance.AccuratePass);
            OverallStats.AerialWon += UpdateIntStat(performance.AerialWon);
            OverallStats.BigChanceCreated += UpdateIntStat(performance.BigChanceCreated);
            OverallStats.BigChanceMissed += UpdateIntStat(performance.BigChanceMissed);
            OverallStats.BlockedScoringAttempt += UpdateIntStat(performance.BlockedScoringAttempt);
            OverallStats.DuelLost += UpdateIntStat(performance.DuelLost);
            OverallStats.DuelWon += UpdateIntStat(performance.DuelWon);
            OverallStats.ErrorLeadToAShot += UpdateIntStat(performance.ErrorLeadToAShot);
            OverallStats.Fouls += UpdateIntStat(performance.Fouls);
            OverallStats.Goals += UpdateIntStat(performance.Goals);
            OverallStats.InterceptionWon += UpdateIntStat(performance.InterceptionWon);
            OverallStats.KeyPass += UpdateIntStat(performance.KeyPass);
            OverallStats.MinutesPlayed += UpdateIntStat(performance.MinutesPlayed);
            OverallStats.OnTargetScoringAttempt += UpdateIntStat(performance.OnTargetScoringAttempt);
            OverallStats.OutfielderBlock += UpdateIntStat(performance.OutfielderBlock);
            OverallStats.PossessionLostCtrl += UpdateIntStat(performance.PossessionLostCtrl);
            OverallStats.Punches += UpdateIntStat(performance.Punches);
            OverallStats.Rating += UpdateDoubleStat(performance.Rating);
            OverallStats.SavedShotsFromInsideTheBox += UpdateIntStat(performance.SavedShotsFromInsideTheBox);
            OverallStats.ShotOffTarget += UpdateIntStat(performance.ShotOffTarget);
            OverallStats.Saves += UpdateIntStat(performance.Saves);
            OverallStats.TotalClearance += UpdateIntStat(performance.TotalClearance);
            OverallStats.TotalCross += UpdateIntStat(performance.TotalCross);
            OverallStats.TotalKeeperSweeper += UpdateIntStat(performance.TotalKeeperSweeper);
            OverallStats.TotalLongBalls += UpdateIntStat(performance.TotalLongBalls);
            OverallStats.TotalOffside += UpdateIntStat(performance.TotalOffside);
            OverallStats.TotalPass += UpdateIntStat(performance.TotalPass);
            OverallStats.TotalTackle += UpdateIntStat(performance.TotalTackle);
            OverallStats.Touches += UpdateIntStat(performance.Touches);
            OverallStats.WasFouled += UpdateIntStat(performance.WasFouled);
        }

        private int UpdateIntStat(int? performanceValue) => (int)(performanceValue != null ? performanceValue : 0);

        private double UpdateDoubleStat(double? performanceValue) => (double)(performanceValue != null ? performanceValue : 0);
    }
}
