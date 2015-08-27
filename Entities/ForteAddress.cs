using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteAddress : ForteEnvironmentDetails
    {
        [JsonProperty("address_id")]
        public string address_id { get; set; }

        [JsonProperty("customer_token")]
        public string customer_token { get; set; }

        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("first_name")]
        public string first_name { get; set; }

        [JsonProperty("last_name")]
        public string last_name { get; set; }

        [JsonProperty("company_name")]
        public string company_name { get; set; }

        [JsonProperty("phone_number")]
        public string phone_number { get; set; }

        [JsonProperty("fax_number")]
        public string fax_number { get; set; }

        [JsonProperty("email_address")]
        public string email_address { get; set; }

        [JsonProperty("address")]
        public FortePhysicalAddress address { get; set; }

        [JsonProperty("links")]
        public Links links { get; set; }

        public ForteAddress()
        {
            address = new FortePhysicalAddress();
            links = new Links();
        }
    }
}
