using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class ElementValue
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("measures")]
        public string Measures { get; set; }
    }
}
