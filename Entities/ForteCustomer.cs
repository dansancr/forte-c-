using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteCustomer : ForteEnvironmentDetails
    {
        [JsonProperty("customer_token", NullValueHandling = NullValueHandling.Ignore)]
        public string customer_token { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string status { get; set; }

        [JsonProperty("first_name")]
        public string first_name { get; set; }

        [JsonProperty("last_name")]
        public string last_name { get; set; }

        [JsonProperty("company_name")]
        public string company_name { get; set; }

        [JsonProperty("default_shipping_address_id", NullValueHandling = NullValueHandling.Ignore)]
        public string default_shipping_address_id { get; set; }

        [JsonIgnore]
        public Links links { get; set; }

        public ForteCustomer()
        {
            links = new Links();
        }
    }
}
