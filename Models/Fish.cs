namespace aspnet_fishies.Models
{
    public enum HabitatType
    {
        Freshwater,
        Saltwater,
        Brackish
    }

    public enum ConservationStatus
    {
        LeastConcern,
        NearThreatened,
        Vulnerable,
        Endangered,
        CriticallyEndangered
    }

    public class Fish
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string ScientificName {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public HabitatType Habitat { get; set; }
        public string Location { get; set; } = string.Empty;
        public ConservationStatus Status { get; set; }
        public decimal AverageWeightKg { get; set; }
        public decimal MarketValue { get; set; }
        public string Seasonality { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
