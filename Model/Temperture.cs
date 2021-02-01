using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class Temperture
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("result")]
        public object Result { get; set; }

        [JsonProperty("records")]
        public RecordElement Records { get; set; }
    }
}
