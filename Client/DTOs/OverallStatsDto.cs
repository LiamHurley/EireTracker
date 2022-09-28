namespace Client.DTOs
{
    public class OverallStatsDto
    {
        public int MatchesPlayed { get; set; }

        #region Goalkeeper Stats
        public int SavedShotsFromInsideTheBox { get; set; }
        public int Saves { get; set; }
        public int Punches { get; set; }
        public int TotalKeeperSweeper { get; set; }
        public int AccurateKeeperSweeper { get; set; }
        #endregion

        #region Defensive Stats
        public int ErrorLeadToAShot { get; set; }
        public int TotalClearance { get; set; }
        public int AerialLost { get; set; }
        public int AerialWon { get; set; }
        public int DuelLost { get; set; }
        public int DuelWon { get; set; }
        public int InterceptionWon { get; set; }
        public int TotalTackle { get; set; }
        public int OutfielderBlock { get; set; }
        #endregion

        #region Passing Stats
        public int TotalPass { get; set; }
        public int GoalAssist { get; set; }
        public int AccuratePass { get; set; }
        public int TotalLongBalls { get; set; }
        public int AccurateLongBalls { get; set; }
        public int TotalCross { get; set; }
        public int AccurateCross { get; set; }
        public int BigChanceCreated { get; set; }
        public int PossessionLostCtrl { get; set; }
        public int KeyPass { get; set; }
        #endregion

        #region Shooting Stats
        public int Goals { get; set; }
        public int BigChanceMissed { get; set; }
        public int ShotOffTarget { get; set; }
        public int OnTargetScoringAttempt { get; set; }
        public int BlockedScoringAttempt { get; set; }
        #endregion

        #region Misc Stats
        public int WasFouled { get; set; }
        public int Fouls { get; set; }
        public int MinutesPlayed { get; set; }
        public int Touches { get; set; }
        public double Rating { get; set; }
        public int TotalOffside { get; set; }
        public int Substitute { get; set; }
        public int Captain { get; set; }
        #endregion
    }
}
