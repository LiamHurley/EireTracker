using API.Data;
using API.Models;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetAllPlayers()
        {
            var players = await _context.Players.Include("Performances").ToListAsync();

            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById(int id)
        {
            var players = await _context.Players.Include("Performances").ToListAsync();
            var player = players.Find(x => x.PlayerId == id);

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
