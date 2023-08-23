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

        [HttpGet("generic/{id}")]
        public async Task<ActionResult<Player>> GetGenericPlayerById(int id)
        {
            if(!await _context.Players.AnyAsync(x => x.PlayerId == id))
            {
                Console.WriteLine("no player with " + id + " found");
                return NoContent();
            }

            var player = await _context.Players
                .Include("Performances")
                .Include("OverallStats")
                .Where(x => x.PlayerId == id)
              .SingleOrDefaultAsync();
            return Ok(player);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            if (!await _context.Players.AnyAsync(x => x.PlayerId == id))
            {
                Console.WriteLine("no player with " + id + " found");
                return NoContent();
            }

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
            Console.WriteLine(player.Name + " found");
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

        [HttpDelete]
        public async Task<ActionResult> DeleteAll()
        {
            _context.Performances.RemoveRange(_context.Performances);
            _context.OverallStats.RemoveRange(_context.OverallStats);
            _context.Players.RemoveRange(_context.Players);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
