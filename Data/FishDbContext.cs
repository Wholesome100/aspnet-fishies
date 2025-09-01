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

            #region SEED DATA
            var fixedTimestamp = new DateTime(2025, 9, 1, 10, 59, 0, DateTimeKind.Utc);

            modelBuilder.Entity<Fish>().HasData(
                new Fish
                {
                    Id = 1,
                    Name = "Atlantic Salmon",
                    ScientificName = "Salmo salar",
                    Description = "A popular fish found in the North Atlantic, valued for its flavor.",
                    Habitat = HabitatType.Saltwater,
                    Location = "North Atlantic Ocean",
                    Status = ConservationStatus.LeastConcern,
                    AverageWeightKg = 4.5m,
                    MarketValue = 15.5m,
                    Seasonality = "Spring-Summer",
                    ImageUrl = "https://example.com/salmon.jpg",
                    LastUpdated = fixedTimestamp
                },
                new Fish
                {
                    Id = 2,
                    Name = "Bluefin Tuna",
                    ScientificName = "Thunnus thynnus",
                    Description = "Highly prized for sushi and sashimi, found in the Atlantic and Pacific.",
                    Habitat = HabitatType.Saltwater,
                    Location = "Atlantic & Pacific Oceans",
                    Status = ConservationStatus.Endangered,
                    AverageWeightKg = 250m,
                    MarketValue = 200.0m,
                    Seasonality = "Year-round",
                    ImageUrl = "https://example.com/tuna.jpg",
                    LastUpdated = fixedTimestamp
                },
                new Fish
                {
                    Id = 3,
                    Name = "Rainbow Trout",
                    ScientificName = "Oncorhynchus mykiss",
                    Description = "A freshwater fish known for its vibrant coloration and popularity among anglers.",
                    Habitat = HabitatType.Freshwater,
                    Location = "North American rivers and lakes",
                    Status = ConservationStatus.LeastConcern,
                    AverageWeightKg = 2.0m,
                    MarketValue = 12.0m,
                    Seasonality = "Spring-Fall",
                    ImageUrl = "https://example.com/trout.jpg",
                    LastUpdated = fixedTimestamp
                },
                new Fish
                {
                    Id = 4,
                    Name = "European Eel",
                    ScientificName = "Anguilla anguilla",
                    Description = "A migratory fish with a complex life cycle, currently facing population decline.",
                    Habitat = HabitatType.Brackish,
                    Location = "European coastal and inland waters",
                    Status = ConservationStatus.CriticallyEndangered,
                    AverageWeightKg = 1.5m,
                    MarketValue = 30.0m,
                    Seasonality = "Winter",
                    ImageUrl = "https://example.com/eel.jpg",
                    LastUpdated = fixedTimestamp
                },
                new Fish
                {
                    Id = 5,
                    Name = "Tilapia",
                    ScientificName = "Oreochromis niloticus",
                    Description = "A widely farmed freshwater fish known for its mild flavor and affordability.",
                    Habitat = HabitatType.Freshwater,
                    Location = "Global aquaculture farms",
                    Status = ConservationStatus.LeastConcern,
                    AverageWeightKg = 1.2m,
                    MarketValue = 5.0m,
                    Seasonality = "Year-round",
                    ImageUrl = "https://example.com/tilapia.jpg",
                    LastUpdated = fixedTimestamp
                }
            );
            #endregion
        }
    }
}
