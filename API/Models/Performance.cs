﻿using System.Text.Json.Serialization;

namespace API.Models
{
    public class Performance
    {
        public int PerformanceId { get; set; }

        public string? MatchDate { get; set; }
        public bool? Substitute { get; set; }
        public bool? Captain { get; set; }

        #region Goalkeeper Stats
        public double? SavedShotsFromInsideTheBox { get; set; }
        public double? Saves { get; set; }
        public double? Punches { get; set; }
        public double? TotalKeeperSweeper { get; set; }
        public double? AccurateKeeperSweeper { get; set; }
        public decimal? GoalsPrevented { get; set; }
        #endregion

        #region Defensive Stats
        public bool? CleanSheet { get; set; }
        public double? ErrorLeadToAShot { get; set; }
        public double? TotalClearance { get; set; }
        public double? AerialLost { get; set; }
        public double? AerialWon { get; set; }
        public double? DuelLost { get; set; }
        public double? DuelWon { get; set; }
        public double? InterceptionWon { get; set; }
        public double? TotalTackle { get; set; }
        public double? OutfielderBlock { get; set; }
        #endregion

        #region Passing Stats
        public double? TotalPass { get; set; }
        public double? GoalAssist { get; set; }
        public double? AccuratePass { get; set; }
        public double? TotalLongBalls { get; set; }
        public double? AccurateLongBalls { get; set; }
        public double? TotalCross { get; set; }
        public double? AccurateCross { get; set; }
        public double? BigChanceCreated { get; set; }
        public double? PossessionLostCtrl { get; set; }
        public double? KeyPass { get; set; }
        public decimal? ExpectedAssists { get; set; }
        #endregion

        #region Shooting Stats
        public double? Goals { get; set; }
        public double? BigChanceMissed { get; set; }
        public double? ShotOffTarget { get; set; }
        public double? OnTargetScoringAttempt { get; set; }
        public double? BlockedScoringAttempt { get; set; }
        public decimal? ExpectedGoals { get; set; }
        #endregion

        #region Misc Stats
        public double? WasFouled { get; set; }
        public double? Fouls { get; set; }
        public double? MinutesPlayed { get; set; }
        public double? Touches { get; set; }
        public double? Rating { get; set; }
        public double? TotalOffside { get; set; }
        #endregion

        #region Match Info

        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public char? HomeAway { get; set; } 

        #endregion

       // public int? PlayerId { get; set; }
        public int SeasonId { get; set; }
        [JsonIgnore]
        public Player? Player { get; set; }

        public DateTime ConvertMatchDateToDateTime(string date)
        {
            return new DateTime(int.Parse(date.Substring(0, 4)), int.Parse(date.Substring(5, 2)), int.Parse(date.Substring(8, 1)));
        }
    }
}
