using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForteSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteResourceSpecific
    {
        [JsonProperty("location_id")]
        public string location_id { get; set; }

        [JsonProperty("customer_token")]
        public string customer_token { get; set; }

        [JsonProperty("paymethod_token")]
        public string paymethod_token { get; set; }

        [JsonProperty("start_settle_date")]
        public string start_settle_date { get; set; }

        [JsonProperty("end_settle_date")]
        public string end_settle_date { get; set; }

        [JsonProperty("start_effective_date")]
        public string start_effective_date { get; set; }

        [JsonProperty("end_effective_date")]
        public string end_effective_date { get; set; }

        [JsonProperty("last_name")]
        public string last_name { get; set; }

        [JsonProperty("start_received_date")]
        public string start_received_date { get; set; }

        [JsonProperty("end_received_date")]
        public string end_received_date { get; set; }

    }
}
