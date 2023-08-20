using API.Models;

namespace API.DTOs
{
    public class PlayerDetailDto : PlayerWithOverallStatsDto
    {
        public List<Performance> Performances { get; set; }
    }
}
