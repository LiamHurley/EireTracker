using API.Data;
using API.DTOs;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OverallStatsController : ControllerBase
    {
        private readonly EireTrackerContext _context;

        public OverallStatsController(EireTrackerContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OverallStatsDto>> GetOverallStatsByPlayerId(int id)
        {
            var overallStats = await _context.OverallStats.SingleAsync(o => o.PlayerId == id);
            var overallStatsDto = overallStats.ConvertToOverallStatsDto();

            return Ok(overallStatsDto);
        }
    }
}