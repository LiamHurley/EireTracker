using API.Models;

namespace API.DTOs
{
    public class SeasonDto
    {
        public int SeasonId { get; set; }
        public string Year { get; set; }
        public OverallStatsDto? OverallStatsDto { get; set; }

        public List<Performance>? Performances { get; set; }
    }
}
