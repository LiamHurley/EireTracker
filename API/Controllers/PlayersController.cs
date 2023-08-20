using API.Data;
using API.Models;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly EireTrackerContext _context;

        public PlayersController(EireTrackerContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddPlayer([FromBody]Player player)
        {
            
            _context.Players.Add(player);
            await _context.Database.OpenConnectionAsync();
            await _context.Database.ExecuteSqlRawAsync(@"SET IDENTITY_INSERT dbo.Players ON");
            var isSaved = await _context.SaveChangesAsync() > 0;
            await _context.Database.ExecuteSqlRawAsync(@"SET IDENTITY_INSERT dbo.Players OFF");

            if (isSaved)
                return Ok(player);

            return BadRequest(new ProblemDetails { Title = "Problem saving player" });
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Player>>> GetAllPlayers()
        {
            var players = await _context.Players.ToListAsync();

            return Ok(players);
        }

       /* [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetAllPlayersWithPerformancesAndOverallStats()
        {
            var players = await _context.Players.Include("Performances")
                .Include("OverallStats")
                .ToListAsync();

            return Ok(players);
        } */

        [HttpGet("overall")]
        public async Task<ActionResult<IEnumerable<PlayerWithOverallStatsDto>>> GetAllPlayersWithOverallStatsAndOverZeroMinutesPlayed()
        {
            var players = await _context.Players.Select(x => new PlayerWithOverallStatsDto
            {
                PlayerId = x.PlayerId,
                Name = x.Name,
                Club = x.Club,
                Position = x.Position,
                DateOfBirth = x.DateOfBirth,
                OverallStatsDto = x.OverallStats.ConvertToOverallStatsDto()
            })
                .ToListAsync();

            players = players.FindAll(p => p.OverallStatsDto.MinutesPlayed > 0);

            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            //var player = await _context.Players.Include("Performances")
            //                             .Include("OverallStats")
            //                             .Where(x => x.PlayerId == id)
            //                             .SingleOrDefaultAsync();

            var player = await _context.Players.Select(x => new PlayerDetailDto
            {
                PlayerId = x.PlayerId,
                Name = x.Name,
                Club = x.Club,
                Position = x.Position,
                DateOfBirth = x.DateOfBirth,
                OverallStatsDto = x.OverallStats.ConvertToOverallStatsDto(),
                Performances = x.Performances
            }).Where(x => x.PlayerId == id)
              .SingleOrDefaultAsync();

            //if (player != null) 
            //    player.SortPerformancesByDate();

            return Ok(player);
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePlayerById([FromBody] Player player)
        {
            _context.Players.Update(player);
            var isSaved = await _context.SaveChangesAsync() > 0;

            if (isSaved)
                return Ok(player);

            return BadRequest(new ProblemDetails { Title = "Problem saving player" });
        }
    }
}
