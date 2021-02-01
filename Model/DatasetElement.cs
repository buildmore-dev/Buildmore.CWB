using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Buildmore.Model
{
    public class DatasetElement
    {
        [JsonProperty("datasetDescription")]
        public string DatasetDescription { get; set; }

        [JsonProperty("locationsName")]
        public string LocationsName { get; set; }

        [JsonProperty("dataid")]
        public string Dataid { get; set; }

        [JsonProperty("location")]
        public IList<LocationElement> Location { get; set; }
    }
}
