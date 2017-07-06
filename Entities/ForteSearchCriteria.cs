using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForteSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteSearchCriteria
    {
        [JsonProperty("page_size")]
        public string page_size { get; set; }

        [JsonProperty("page_index")]
        public string page_index { get; set; }

        [JsonProperty("home_organization_id")]
        public string home_organization_id { get; set; }

        [JsonProperty("resource_specific")]
        public ForteResourceSpecific resource_specific { get; set; }

        public ForteSearchCriteria()
        {
            resource_specific = new ForteResourceSpecific();
        }
    }
}
