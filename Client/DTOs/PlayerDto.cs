namespace Client.DTOs
{
    public class PlayerDto
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        public OverallStatsDto OverallStatsDto { get; set; }

        public void ConvertStatsToPerNinety()
        {
            OverallStatsDto.AccurateCross = ConvertTotalToPerNinety(OverallStatsDto.AccurateCross);
            OverallStatsDto.AccurateKeeperSweeper = ConvertTotalToPerNinety(OverallStatsDto.AccurateKeeperSweeper);
            OverallStatsDto.AccurateLongBalls = ConvertTotalToPerNinety(OverallStatsDto.AccurateLongBalls);
            OverallStatsDto.AerialLost = ConvertTotalToPerNinety(OverallStatsDto.AerialLost);
            OverallStatsDto.AccuratePass = ConvertTotalToPerNinety(OverallStatsDto.AccuratePass);
            OverallStatsDto.AerialWon = ConvertTotalToPerNinety(OverallStatsDto.AerialWon);
            OverallStatsDto.BigChanceCreated = ConvertTotalToPerNinety(OverallStatsDto.BigChanceCreated);
            OverallStatsDto.BigChanceMissed = ConvertTotalToPerNinety(OverallStatsDto.BigChanceMissed);
            OverallStatsDto.BlockedScoringAttempt = ConvertTotalToPerNinety(OverallStatsDto.BlockedScoringAttempt);
            OverallStatsDto.DuelLost = ConvertTotalToPerNinety(OverallStatsDto.DuelLost);
            OverallStatsDto.DuelWon = ConvertTotalToPerNinety(OverallStatsDto.DuelWon);
            OverallStatsDto.ErrorLeadToAShot = ConvertTotalToPerNinety(OverallStatsDto.ErrorLeadToAShot);
            OverallStatsDto.Fouls = ConvertTotalToPerNinety(OverallStatsDto.Fouls);
            OverallStatsDto.Goals = ConvertTotalToPerNinety(OverallStatsDto.Goals);
            OverallStatsDto.GoalAssist = ConvertTotalToPerNinety(OverallStatsDto.GoalAssist);
            OverallStatsDto.InterceptionWon = ConvertTotalToPerNinety(OverallStatsDto.InterceptionWon);
            OverallStatsDto.KeyPass = ConvertTotalToPerNinety(OverallStatsDto.KeyPass);
            OverallStatsDto.OnTargetScoringAttempt = ConvertTotalToPerNinety(OverallStatsDto.OnTargetScoringAttempt);
            OverallStatsDto.OutfielderBlock = ConvertTotalToPerNinety(OverallStatsDto.OutfielderBlock);
            OverallStatsDto.PossessionLostCtrl = ConvertTotalToPerNinety(OverallStatsDto.PossessionLostCtrl);
            OverallStatsDto.Punches = ConvertTotalToPerNinety(OverallStatsDto.Punches);
            OverallStatsDto.SavedShotsFromInsideTheBox = ConvertTotalToPerNinety(OverallStatsDto.SavedShotsFromInsideTheBox);
            OverallStatsDto.ShotOffTarget = ConvertTotalToPerNinety(OverallStatsDto.ShotOffTarget);
            OverallStatsDto.Saves = ConvertTotalToPerNinety(OverallStatsDto.Saves);
            OverallStatsDto.TotalClearance = ConvertTotalToPerNinety(OverallStatsDto.TotalClearance);
            OverallStatsDto.TotalCross = ConvertTotalToPerNinety(OverallStatsDto.TotalCross);
            OverallStatsDto.TotalKeeperSweeper = ConvertTotalToPerNinety(OverallStatsDto.TotalKeeperSweeper);
            OverallStatsDto.TotalLongBalls = ConvertTotalToPerNinety(OverallStatsDto.TotalLongBalls);
            OverallStatsDto.TotalOffside = ConvertTotalToPerNinety(OverallStatsDto.TotalOffside);
            OverallStatsDto.TotalPass = ConvertTotalToPerNinety(OverallStatsDto.TotalPass);
            OverallStatsDto.TotalTackle = ConvertTotalToPerNinety(OverallStatsDto.TotalTackle);
            OverallStatsDto.Touches = ConvertTotalToPerNinety(OverallStatsDto.Touches);
            OverallStatsDto.WasFouled = ConvertTotalToPerNinety(OverallStatsDto.WasFouled);
        }

        public void ConvertStatsToTotal()
        {
            OverallStatsDto.AccurateCross = ConvertPerNinetyToTotal(OverallStatsDto.AccurateCross);
            OverallStatsDto.AccurateKeeperSweeper = ConvertPerNinetyToTotal(OverallStatsDto.AccurateKeeperSweeper);
            OverallStatsDto.AccurateLongBalls = ConvertPerNinetyToTotal(OverallStatsDto.AccurateLongBalls);
            OverallStatsDto.AerialLost = ConvertPerNinetyToTotal(OverallStatsDto.AerialLost);
            OverallStatsDto.AccuratePass = ConvertPerNinetyToTotal(OverallStatsDto.AccuratePass);
            OverallStatsDto.AerialWon = ConvertPerNinetyToTotal(OverallStatsDto.AerialWon);
            OverallStatsDto.BigChanceCreated = ConvertPerNinetyToTotal(OverallStatsDto.BigChanceCreated);
            OverallStatsDto.BigChanceMissed = ConvertPerNinetyToTotal(OverallStatsDto.BigChanceMissed);
            OverallStatsDto.BlockedScoringAttempt = ConvertPerNinetyToTotal(OverallStatsDto.BlockedScoringAttempt);
            OverallStatsDto.DuelLost = ConvertPerNinetyToTotal(OverallStatsDto.DuelLost);
            OverallStatsDto.DuelWon = ConvertPerNinetyToTotal(OverallStatsDto.DuelWon);
            OverallStatsDto.ErrorLeadToAShot = ConvertPerNinetyToTotal(OverallStatsDto.ErrorLeadToAShot);
            OverallStatsDto.Fouls = ConvertPerNinetyToTotal(OverallStatsDto.Fouls);
            OverallStatsDto.Goals = ConvertPerNinetyToTotal(OverallStatsDto.Goals);
            OverallStatsDto.GoalAssist = ConvertPerNinetyToTotal(OverallStatsDto.GoalAssist);
            OverallStatsDto.InterceptionWon = ConvertPerNinetyToTotal(OverallStatsDto.InterceptionWon);
            OverallStatsDto.KeyPass = ConvertPerNinetyToTotal(OverallStatsDto.KeyPass);
            OverallStatsDto.OnTargetScoringAttempt = ConvertPerNinetyToTotal(OverallStatsDto.OnTargetScoringAttempt);
            OverallStatsDto.OutfielderBlock = ConvertPerNinetyToTotal(OverallStatsDto.OutfielderBlock);
            OverallStatsDto.PossessionLostCtrl = ConvertPerNinetyToTotal(OverallStatsDto.PossessionLostCtrl);
            OverallStatsDto.Punches = ConvertPerNinetyToTotal(OverallStatsDto.Punches);
            OverallStatsDto.SavedShotsFromInsideTheBox = ConvertPerNinetyToTotal(OverallStatsDto.SavedShotsFromInsideTheBox);
            OverallStatsDto.ShotOffTarget = ConvertPerNinetyToTotal(OverallStatsDto.ShotOffTarget);
            OverallStatsDto.Saves = ConvertPerNinetyToTotal(OverallStatsDto.Saves);
            OverallStatsDto.TotalClearance = ConvertPerNinetyToTotal(OverallStatsDto.TotalClearance);
            OverallStatsDto.TotalCross = ConvertPerNinetyToTotal(OverallStatsDto.TotalCross);
            OverallStatsDto.TotalKeeperSweeper = ConvertPerNinetyToTotal(OverallStatsDto.TotalKeeperSweeper);
            OverallStatsDto.TotalLongBalls = ConvertPerNinetyToTotal(OverallStatsDto.TotalLongBalls);
            OverallStatsDto.TotalOffside = ConvertPerNinetyToTotal(OverallStatsDto.TotalOffside);
            OverallStatsDto.TotalPass = ConvertPerNinetyToTotal(OverallStatsDto.TotalPass);
            OverallStatsDto.TotalTackle = ConvertPerNinetyToTotal(OverallStatsDto.TotalTackle);
            OverallStatsDto.Touches = ConvertPerNinetyToTotal(OverallStatsDto.Touches);
            OverallStatsDto.WasFouled = ConvertPerNinetyToTotal(OverallStatsDto.WasFouled);
        }

        private double ConvertTotalToPerNinety(double stat) => Math.Round(stat / OverallStatsDto.MinutesPlayed * 90, 2, MidpointRounding.AwayFromZero);

        private double ConvertPerNinetyToTotal(double stat) => Math.Round(stat / 90 * OverallStatsDto.MinutesPlayed, 0, MidpointRounding.AwayFromZero);

        public string CalculatePercentage(double stat, double statToDivideBy)
        {
            if (statToDivideBy == 0)
                return "-";
            
            return Math.Round((stat / statToDivideBy) * 100, 2, MidpointRounding.AwayFromZero).ToString();
        }
    }
}
