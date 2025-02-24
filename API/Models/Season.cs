using API.DTOs;

namespace API.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public int PlayerId { get; set; }
        public string Year { get; set; }
        public OverallStats? OverallStats { get; set; } = new OverallStats();

        public List<Performance>? Performances { get; set; } = new List<Performance>();

        public SeasonDto ConvertToSeasonDto()
        {
            return new SeasonDto()
            {
                SeasonId = this.SeasonId,
                Year = this.Year,
                OverallStatsDto = this.OverallStats?.ConvertToOverallStatsDto(),
                Performances = this.Performances
            };
        }
    }
}