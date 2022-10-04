namespace Client
{
    public static class Utils
    {
        private static readonly List<string> _notSortableStats = new List<string> {
            "Name", "Club", 
        };

        public static bool IsASortableStat(string stat) => !_notSortableStats.Contains(stat);
    }
}
