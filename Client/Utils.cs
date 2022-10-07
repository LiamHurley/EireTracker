namespace Client
{
    public static class Utils
    {
        private static readonly List<string> _notSortableStats = new List<string> {
            "Name", "Club", 
        };

        public static bool IsASortableStat(string stat) => !_notSortableStats.Contains(stat);

        public static class TableHeaders
        {
            public static readonly string[] _shootingStatsTableHeaders = { "Name", "Club", "Minutes", "Goals", "Minutes Per Goal", "Shots", "Shots On Target", "Big Chances Missed", };
            public static readonly string[] _goalkeepingStatsTableHeaders = { "Name", "Club", "Appearances", "Clean Sheets", "Saves",
                                                                "Pass Completion (%)", "Long Ball Completion (%)", "Errors Leading To Shot", "Average Rating" };
            public static readonly string[] _defendingStatsTableHeaders = { "Name", "Club", "Appearances", "Minutes", "Duels Won (%)", "Aerial Duels Won (%)",
                                                              "Tackles", "Shots Blocked", "Errors Leading To Shot" };
            public static readonly string[] _generalStatsTableHeaders = { "Name", "Club", "Age", "Appearances", "Minutes", "Goals", "Assists", "Average Rating" };
        }
    }
}
