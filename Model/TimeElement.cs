using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class TimeElement
    {
        [JsonProperty("dataTime")]
        public DateTime DataTime { get; set; }


        [JsonProperty("elementValue")]
        public IList<ElementValue> ElementValue { get; set; }
    }
}
