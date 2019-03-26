using Newtonsoft.Json;

namespace EarthquakeTest.Models
{
    public class Feature
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }
}