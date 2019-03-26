using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EarthquakeTest.Models
{
    public class FeatureCollection
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }    
}