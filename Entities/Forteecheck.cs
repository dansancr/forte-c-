using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Echeck
    {
        [JsonProperty("routing_number")]
        public string routing_number { get; set; }
        [JsonProperty("account_type")]
        public string account_type { get; set; }
        [JsonProperty("account_number")]
        public string account_number { get; set; }
        [JsonProperty("masked_account_number")]
        public string masked_account_number { get; set; }
    }
}
