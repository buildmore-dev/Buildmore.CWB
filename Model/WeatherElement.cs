using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class WeatherElement
    {
        [JsonProperty("elementName")]
        public string ElementName { get; set; }


        [JsonProperty("description")]
        public string Description { get; set; }


        [JsonProperty("time")]
        public IList<TimeElement> Time { get; set; }
    }
}
