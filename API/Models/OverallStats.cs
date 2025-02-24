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
        public decimal GoalsPrevented { get; set; }
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
        public decimal ExpectedAssists { get; set; }
        #endregion

        #region Shooting Stats
        public double Goals { get; set; }
        public double BigChanceMissed { get; set; }
        public double TotalShotsTaken { get; set; }
        public double ShotOffTarget { get; set; }
        public double OnTargetScoringAttempt { get; set; }
        public double BlockedScoringAttempt { get; set; }
        public decimal ExpectedGoals { get; set; }
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

        public int? SeasonId { get; set; }
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
                AverageRating = this.MatchesPlayed == 0 ? 0 : Math.Round(this.Rating / this.MatchesPlayed, 2, MidpointRounding.AwayFromZero),
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
                PassAccuracy = CalculateStatPercentage(this.AccuratePass, this.TotalPass),
                DuelWonPercentage = CalculateStatPercentage(this.DuelWon, this.TotalDuels),
                AerialDuelsWonPercentage = CalculateStatPercentage(this.AerialWon, this.TotalAerialDuels),
                LongBallAccuracy = CalculateStatPercentage(this.AccurateLongBalls, this.TotalLongBalls),
                GoalsPrevented = decimal.Parse(this.GoalsPrevented.ToString("n2")),
                ExpectedAssists = decimal.Parse(this.ExpectedAssists.ToString("n2")),
                ExpectedGoals = decimal.Parse(this.ExpectedGoals.ToString("n2"))
            };
        }

        private static double CalculateStatPercentage(double statToDivide, double statToDivideBy) => statToDivideBy == 0 ? 0 : Math.Round((statToDivide / statToDivideBy) * 100, 2, MidpointRounding.AwayFromZero);

        public void Update(Performance performance)
        {
            if (performance.MinutesPlayed > 0)
            {
                this.MatchesPlayed++;
                this.Rating += UpdateDoubleStat(performance.Rating);
                this.AverageRating = Math.Round(UpdateDoubleStat(this.Rating / this.MatchesPlayed), 2, MidpointRounding.AwayFromZero);
                this.CleanSheets += (bool)performance.CleanSheet ? 1 : 0;
            }

            this.AccurateCross += UpdateDoubleStat(performance.AccurateCross);
            this.AccurateKeeperSweeper += UpdateDoubleStat(performance.AccurateKeeperSweeper);
            this.AccurateLongBalls += UpdateDoubleStat(performance.AccurateLongBalls);
            this.AerialLost += UpdateDoubleStat(performance.AerialLost);
            this.AccuratePass += UpdateDoubleStat(performance.AccuratePass);
            this.AerialWon += UpdateDoubleStat(performance.AerialWon);
            this.BigChanceCreated += UpdateDoubleStat(performance.BigChanceCreated);
            this.BigChanceMissed += UpdateDoubleStat(performance.BigChanceMissed);
            this.BlockedScoringAttempt += UpdateDoubleStat(performance.BlockedScoringAttempt);
            this.DuelLost += UpdateDoubleStat(performance.DuelLost);
            this.DuelWon += UpdateDoubleStat(performance.DuelWon);
            this.ErrorLeadToAShot += UpdateDoubleStat(performance.ErrorLeadToAShot);
            this.Fouls += UpdateDoubleStat(performance.Fouls);
            this.Goals += UpdateDoubleStat(performance.Goals);
            this.GoalAssist += UpdateDoubleStat(performance.GoalAssist);
            this.InterceptionWon += UpdateDoubleStat(performance.InterceptionWon);
            this.KeyPass += UpdateDoubleStat(performance.KeyPass);
            this.MinutesPlayed += UpdateDoubleStat(performance.MinutesPlayed);
            this.OnTargetScoringAttempt += UpdateDoubleStat(performance.OnTargetScoringAttempt);
            this.OutfielderBlock += UpdateDoubleStat(performance.OutfielderBlock);
            this.PossessionLostCtrl += UpdateDoubleStat(performance.PossessionLostCtrl);
            this.Punches += UpdateDoubleStat(performance.Punches);
            this.SavedShotsFromInsideTheBox += UpdateDoubleStat(performance.SavedShotsFromInsideTheBox);
            this.ShotOffTarget += UpdateDoubleStat(performance.ShotOffTarget);
            this.Saves += UpdateDoubleStat(performance.Saves);
            this.TotalShotsTaken += UpdateDoubleStat(performance.BlockedScoringAttempt + performance.OnTargetScoringAttempt + performance.ShotOffTarget);
            this.TotalAerialDuels += UpdateDoubleStat(performance.AerialLost + performance.AerialWon);
            this.TotalDuels += UpdateDoubleStat(performance.DuelLost + performance.DuelWon);
            this.TotalClearance += UpdateDoubleStat(performance.TotalClearance);
            this.TotalCross += UpdateDoubleStat(performance.TotalCross);
            this.TotalKeeperSweeper += UpdateDoubleStat(performance.TotalKeeperSweeper);
            this.TotalLongBalls += UpdateDoubleStat(performance.TotalLongBalls);
            this.TotalOffside += UpdateDoubleStat(performance.TotalOffside);
            this.TotalPass += UpdateDoubleStat(performance.TotalPass);
            this.TotalTackle += UpdateDoubleStat(performance.TotalTackle);
            this.Touches += UpdateDoubleStat(performance.Touches);
            this.WasFouled += UpdateDoubleStat(performance.WasFouled);
            this.ExpectedAssists += UpdateDecimalStat(performance.ExpectedAssists);
            this.ExpectedGoals += UpdateDecimalStat(performance.ExpectedGoals);
            this.GoalsPrevented += UpdateDecimalStat(performance.GoalsPrevented);

            if (performance.Captain == true)
                this.Captain++;

            if (performance.Substitute != null && performance.Substitute == true)
                this.Substitute++;
        }

        private double UpdateDoubleStat(double? performanceValue) => (double)(performanceValue != null ? performanceValue : 0);

        private decimal UpdateDecimalStat(decimal? performanceValue) => (decimal)(performanceValue != null ? performanceValue : 0);
    }
}
