namespace Client.DTOs
{
    public class OverallStatsDto
    {
        public int MatchesPlayed { get; set; }

        #region Goalkeeper Stats
        public double SavedShotsFromInsideTheBox { get; set; }
        public double Saves { get; set; }
        public double Punches { get; set; }
        public double TotalKeeperSweeper { get; set; }
        public double AccurateKeeperSweeper { get; set; }
        #endregion

        #region Defensive Stats
        public double ErrorLeadToAShot { get; set; }
        public double TotalClearance { get; set; }
        public double AerialLost { get; set; }
        public double AerialWon { get; set; }
        public double DuelLost { get; set; }
        public double DuelWon { get; set; }
        public double InterceptionWon { get; set; }
        public double TotalTackle { get; set; }
        public double OutfielderBlock { get; set; }
        #endregion

        #region Passing Stats
        public double TotalPass { get; set; }
        public double GoalAssist { get; set; }
        public double AccuratePass { get; set; }
        public double TotalLongBalls { get; set; }
        public double AccurateLongBalls { get; set; }
        public double TotalCross { get; set; }
        public double AccurateCross { get; set; }
        public double BigChanceCreated { get; set; }
        public double PossessionLostCtrl { get; set; }
        public double KeyPass { get; set; }
        #endregion

        #region Shooting Stats
        public double Goals { get; set; }
        public double BigChanceMissed { get; set; }
        public double ShotOffTarget { get; set; }
        public double OnTargetScoringAttempt { get; set; }
        public double BlockedScoringAttempt { get; set; }
        #endregion

        #region Misc Stats
        public double WasFouled { get; set; }
        public double Fouls { get; set; }
        public double MinutesPlayed { get; set; }
        public double Touches { get; set; }
        public double Rating { get; set; }
        public double AverageRating { get; set; }
        public double TotalOffside { get; set; }
        public double Substitute { get; set; }
        public double Captain { get; set; }
        #endregion
    }
}
