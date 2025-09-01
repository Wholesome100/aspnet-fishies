using Microsoft.EntityFrameworkCore;
using aspnet_fishies.Models;

namespace aspnet_fishies.Data
{
    public class FishDbContext : DbContext
    {
        public FishDbContext(DbContextOptions<FishDbContext> options) : base(options) { }

        public DbSet<Fish> Fish => Set<Fish>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Convert enums into strings for readability
            modelBuilder.Entity<Fish>()
                .Property(f => f.Habitat)
                .HasConversion<string>();

            modelBuilder.Entity<Fish>()
                .Property(f => f.Status)
                .HasConversion<string>();
        }
    }
}
