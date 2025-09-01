namespace aspnet_fishies.Models
{
    public class Fish
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string ScientificName {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Habitat { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal AverageWeightKg { get; set; }
        public decimal MarketValue { get; set; }
        public string Seasonality { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
