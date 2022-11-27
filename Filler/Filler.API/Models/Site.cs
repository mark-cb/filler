using System.Text.Json.Serialization;

namespace Filler.API.Models
{
    public class Site
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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

        public double FuelCost => 1.83;
    }
    
}
