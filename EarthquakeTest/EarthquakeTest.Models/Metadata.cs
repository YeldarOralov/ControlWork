using Newtonsoft.Json;

namespace EarthquakeTest.Models
{
    public class Metadata
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}