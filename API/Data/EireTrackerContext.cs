using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EireTrackerContext : DbContext
    {
       // private IConfiguration config;

        public EireTrackerContext(DbContextOptions<EireTrackerContext> options) : base(options)
        {
            //config = configuration;
        }

        //public EireTrackerContext()
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"),
        //        ServerVersion.AutoDetect(config.GetConnectionString("DefaultConnection")));
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(p => p.Seasons)
                .WithOne()
                .HasForeignKey(s => s.PlayerId)
                .IsRequired();

            modelBuilder.Entity<Season>()
                .HasMany(s => s.Performances)
                .WithOne()
                .HasForeignKey(p => p.SeasonId)
                .IsRequired();

            modelBuilder.Entity<Season>()
                .HasOne(s => s.OverallStats)
                .WithOne()
                .HasForeignKey<OverallStats>(o => o.SeasonId)
                .IsRequired(false);

            //modelBuilder.Entity<Player>()
            //    .HasMany(o => o.OverallStats)

            modelBuilder.Entity<Performance>()
                .Property(p => p.AccurateCross)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.AccurateKeeperSweeper)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.AccurateLongBalls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.AccuratePass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.AerialLost)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.AerialWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.BigChanceCreated)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.BigChanceMissed)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.BlockedScoringAttempt)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.DuelLost)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.DuelWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.ErrorLeadToAShot)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Fouls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Goals)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.GoalAssist)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.InterceptionWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.KeyPass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.MinutesPlayed)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.OnTargetScoringAttempt)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.OutfielderBlock)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.PossessionLostCtrl)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Punches)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Rating)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Saves)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.SavedShotsFromInsideTheBox)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.ShotOffTarget)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalClearance)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalCross)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalKeeperSweeper)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalLongBalls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalOffside)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalPass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.TotalTackle)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Touches)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.WasFouled)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Substitute)
                .HasDefaultValue(false);

            modelBuilder.Entity<Performance>()
                .Property(p => p.Captain)
                .HasDefaultValue(false);

            modelBuilder.Entity<Performance>()
                .Property(p => p.CleanSheet)
                .HasDefaultValue(false);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AccurateCross)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AccurateKeeperSweeper)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AccurateLongBalls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AccuratePass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AerialLost)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AerialWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.BigChanceCreated)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.BigChanceMissed)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.BlockedScoringAttempt)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.DuelLost)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.DuelWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.ErrorLeadToAShot)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Fouls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Goals)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.GoalAssist)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.InterceptionWon)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.KeyPass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.MinutesPlayed)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.OnTargetScoringAttempt)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.OutfielderBlock)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.PossessionLostCtrl)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Punches)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Rating)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.AverageRating)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Saves)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.CleanSheets)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.SavedShotsFromInsideTheBox)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.ShotOffTarget)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalClearance)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalCross)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalKeeperSweeper)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalLongBalls)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalOffside)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalPass)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalTackle)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Touches)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.WasFouled)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Substitute)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.Captain)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.MatchesPlayed)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalShotsTaken)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalAerialDuels)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.TotalDuels)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.ExpectedGoals)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.ExpectedAssists)
                .HasDefaultValue(0.0);

            modelBuilder.Entity<OverallStats>()
                .Property(p => p.GoalsPrevented)
                .HasDefaultValue(0.0);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<OverallStats> OverallStats { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Season> Seasons { get; set; }
    }
}
