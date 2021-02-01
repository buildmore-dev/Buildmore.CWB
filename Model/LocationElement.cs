using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class LocationElement
    {
        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("geocode")]
        public string Geocode { get; set; }

        [JsonProperty("lat")]
        public decimal Lat { get; set; }

        [JsonProperty("lon")]
        public decimal Lon { get; set; }

        [JsonProperty("weatherElement")]
        public IList<WeatherElement> WeatherElement { get; set; }
    }
}
