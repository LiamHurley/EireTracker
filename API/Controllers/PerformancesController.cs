using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformancesController : ControllerBase
    {
        private readonly EireTrackerContext _context;

        public PerformancesController(EireTrackerContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Performance>>> GetPerformancesByPlayerId(int id)
        {
            var performances = await _context.Performances.ToListAsync();
            performances = performances.FindAll(p => p.PlayerId == id && p.MinutesPlayed > 0);

            return Ok(performances);
        }
    }
}
