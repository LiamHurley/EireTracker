using API.DTOs;
using System.Text.Json.Serialization;

namespace API.Models
{
    public class OverallStats
    {
        public int OverallStatsId { get; set; }
        public int MatchesPlayed { get; set; }

        #region Goalkeeper Stats
        public double SavedShotsFromInsideTheBox { get; set; }
        public double Saves { get; set; }
        public double Punches { get; set; }
        public double TotalKeeperSweeper { get; set; }
        public double AccurateKeeperSweeper { get; set; }
        #endregion

        #region Defensive Stats
        public double CleanSheets { get; set; }
        public double ErrorLeadToAShot { get; set; }
        public double TotalClearance { get; set; }
        public double TotalAerialDuels { get; set; }
        public double AerialLost { get; set; }
        public double AerialWon { get; set; }
        public double TotalDuels { get; set; }
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
        public double TotalShotsTaken { get; set; }
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

        public int? PlayerId { get; set; }
        [JsonIgnore]
        public Player? Player { get; set; }

        public OverallStatsDto ConvertToOverallStatsDto()
        {
            return new()
            {
                MatchesPlayed = this.MatchesPlayed,
                AccurateCross = this.AccurateCross,
                AccurateKeeperSweeper = this.AccurateKeeperSweeper,
                AccurateLongBalls = this.AccurateLongBalls,
                AerialLost = this.AerialLost,
                AccuratePass = this.AccuratePass,
                AerialWon = this.AerialWon,
                BigChanceCreated = this.BigChanceCreated,
                BigChanceMissed = this.BigChanceMissed,
                BlockedScoringAttempt = this.BlockedScoringAttempt,
                Captain = this.Captain,
                DuelLost = this.DuelLost,
                DuelWon = this.DuelWon,
                ErrorLeadToAShot = this.ErrorLeadToAShot,
                Fouls = this.Fouls,
                Goals = this.Goals,
                GoalAssist = this.GoalAssist,
                InterceptionWon = this.InterceptionWon,
                KeyPass = this.KeyPass,
                MinutesPlayed = this.MinutesPlayed,
                OnTargetScoringAttempt = this.OnTargetScoringAttempt,
                OutfielderBlock = this.OutfielderBlock,
                PossessionLostCtrl = this.PossessionLostCtrl,
                Punches = this.Punches,
                Rating = this.Rating,
                AverageRating = Math.Round(this.Rating / this.MatchesPlayed, 2, MidpointRounding.AwayFromZero),
                SavedShotsFromInsideTheBox = this.SavedShotsFromInsideTheBox,
                ShotOffTarget = this.ShotOffTarget,
                Saves = this.Saves,
                Substitute = this.Substitute,
                TotalDuels = this.TotalDuels,
                TotalAerialDuels = this.TotalAerialDuels,
                TotalShotsTaken = this.TotalShotsTaken,
                TotalClearance = this.TotalClearance,
                TotalCross = this.TotalCross,
                TotalKeeperSweeper = this.TotalKeeperSweeper,
                TotalLongBalls = this.TotalLongBalls,
                TotalOffside = this.TotalOffside,
                TotalPass = this.TotalPass,
                TotalTackle = this.TotalTackle,
                Touches = this.Touches,
                WasFouled = this.WasFouled,
                PassAccuracy = sortMe(this.AccuratePass, this.TotalPass),
                DuelWonPercentage = sortMe(this.DuelWon, this.TotalDuels),
                AerialDuelsWonPercentage = sortMe(this.AerialWon, this.TotalAerialDuels),
                LongBallAccuracy = sortMe(this.AccurateLongBalls, this.TotalLongBalls)
            };
        }

        private double sortMe(double a, double b)
        {
            if(b == 0)
            {
                return 0;
            }
            return Math.Round((a / b) * 100, 2, MidpointRounding.AwayFromZero);
        }
    }
}
