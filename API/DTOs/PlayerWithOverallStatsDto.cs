namespace API.DTOs
{
    public class PlayerWithOverallStatsDto
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        public OverallStatsDto OverallStatsDto { get; set; }
    }
}
