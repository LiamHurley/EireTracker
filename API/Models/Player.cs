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
            //if 0, return? Or create new field to track appearances off bench, etc?

            if (performance.MinutesPlayed > 0)
            {
                OverallStats.MatchesPlayed++;
                OverallStats.Rating += UpdateDoubleStat(performance.Rating);
                OverallStats.AverageRating = Math.Round(UpdateDoubleStat(OverallStats.Rating / OverallStats.MatchesPlayed), 2, MidpointRounding.AwayFromZero);
            }

            OverallStats.AccurateCross += UpdateDoubleStat(performance.AccurateCross);
            OverallStats.AccurateKeeperSweeper += UpdateDoubleStat(performance.AccurateKeeperSweeper);
            OverallStats.AccurateLongBalls += UpdateDoubleStat(performance.AccurateLongBalls);
            OverallStats.AerialLost += UpdateDoubleStat(performance.AerialLost);
            OverallStats.AccuratePass += UpdateDoubleStat(performance.AccuratePass);
            OverallStats.AerialWon += UpdateDoubleStat(performance.AerialWon);
            OverallStats.BigChanceCreated += UpdateDoubleStat(performance.BigChanceCreated);
            OverallStats.BigChanceMissed += UpdateDoubleStat(performance.BigChanceMissed);
            OverallStats.BlockedScoringAttempt += UpdateDoubleStat(performance.BlockedScoringAttempt);
            OverallStats.DuelLost += UpdateDoubleStat(performance.DuelLost);
            OverallStats.DuelWon += UpdateDoubleStat(performance.DuelWon);
            OverallStats.ErrorLeadToAShot += UpdateDoubleStat(performance.ErrorLeadToAShot);
            OverallStats.Fouls += UpdateDoubleStat(performance.Fouls);
            OverallStats.Goals += UpdateDoubleStat(performance.Goals);
            OverallStats.GoalAssist += UpdateDoubleStat(performance.GoalAssist);
            OverallStats.InterceptionWon += UpdateDoubleStat(performance.InterceptionWon);
            OverallStats.KeyPass += UpdateDoubleStat(performance.KeyPass);
            OverallStats.MinutesPlayed += UpdateDoubleStat(performance.MinutesPlayed);
            OverallStats.OnTargetScoringAttempt += UpdateDoubleStat(performance.OnTargetScoringAttempt);
            OverallStats.OutfielderBlock += UpdateDoubleStat(performance.OutfielderBlock);
            OverallStats.PossessionLostCtrl += UpdateDoubleStat(performance.PossessionLostCtrl);
            OverallStats.Punches += UpdateDoubleStat(performance.Punches);
            OverallStats.SavedShotsFromInsideTheBox += UpdateDoubleStat(performance.SavedShotsFromInsideTheBox);
            OverallStats.ShotOffTarget += UpdateDoubleStat(performance.ShotOffTarget);
            OverallStats.Saves += UpdateDoubleStat(performance.Saves);
            OverallStats.TotalClearance += UpdateDoubleStat(performance.TotalClearance);
            OverallStats.TotalCross += UpdateDoubleStat(performance.TotalCross);
            OverallStats.TotalKeeperSweeper += UpdateDoubleStat(performance.TotalKeeperSweeper);
            OverallStats.TotalLongBalls += UpdateDoubleStat(performance.TotalLongBalls);
            OverallStats.TotalOffside += UpdateDoubleStat(performance.TotalOffside);
            OverallStats.TotalPass += UpdateDoubleStat(performance.TotalPass);
            OverallStats.TotalTackle += UpdateDoubleStat(performance.TotalTackle);
            OverallStats.Touches += UpdateDoubleStat(performance.Touches);
            OverallStats.WasFouled += UpdateDoubleStat(performance.WasFouled);

            if (performance.Captain != null)
                OverallStats.Captain++;

            if(performance.Substitute != null && performance.Substitute == true)
                OverallStats.Substitute++;
        }
        private double UpdateDoubleStat(double? performanceValue) => (double)(performanceValue != null ? performanceValue : 0);
    }
}
