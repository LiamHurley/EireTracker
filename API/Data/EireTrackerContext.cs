using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EireTrackerContext : DbContext
    {
        public EireTrackerContext(DbContextOptions options) : base(options)
        {

        }

        public EireTrackerContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(p => p.OverallStats)
                .WithOne(o => o.Player);

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Performances)
                .WithOne(o => o.Player);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<StatsProfile> StatsProfiles { get; set; }
        public DbSet<Performance> Performances { get; set; }
    }
}
