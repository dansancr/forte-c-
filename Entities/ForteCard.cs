using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Card
    {
        [JsonProperty("card_type")]
        public string card_type { get; set; }
        [JsonProperty("name_on_card")]
        public string name_on_card { get; set; }
        [JsonProperty("account_number")]
        public string account_number { get; set; }
        [JsonProperty("expire_month")]
        public string expire_month { get; set; }
        [JsonProperty("expire_year")]
        public string expire_year { get; set; }
        [JsonProperty("masked_account_number")]
        public string masked_account_number { get; set; }
    }
}
