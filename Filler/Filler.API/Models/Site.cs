using System.Text.Json.Serialization;

namespace Filler.API.Models
{
    public class Site
    {
        [JsonPropertyName("siteId")]
        public int SiteId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("numberOfPumps")]
        public int NumberOfPumps { get; set; }

        [JsonPropertyName("fuelServed")]
        public List<string> FuelServed => new List<string> { "Petrol", "Diesel" };

        [JsonPropertyName("fuelCost")]
        public double FuelCost => 1.83;

        public List<Pump> SitePumps { get; set; }

        
    }
    
}
