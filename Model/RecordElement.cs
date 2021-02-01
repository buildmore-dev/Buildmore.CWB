using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class RecordElement
    {
        [JsonProperty("locations")]
        public IList<DatasetElement> Locations { get; set; }
    }
}
