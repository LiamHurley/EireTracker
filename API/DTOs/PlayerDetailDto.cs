using API.Models;

namespace API.DTOs
{
    public class PlayerDetailDto
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        //public OverallStatsDto OverallStatsDto { get; set; }
        //public List<Performance> Performances { get; set; }
        public List<SeasonDto>? Seasons { get; set; }
    }
}
