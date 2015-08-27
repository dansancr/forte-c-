using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteTransaction : ForteEnvironmentDetails
    {
        [JsonProperty("transaction_id")]
        public string transaction_id { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("original_transaction_id")]
        public string original_transaction_id { get; set; }
        [JsonProperty("account_id")]
        public string account_id { get; set; }
        [JsonProperty("customer_token")]
        public string customer_token { get; set; }
        [JsonProperty("paymethod_token")]
        public string paymethod_token { get; set; }
        [JsonProperty("order_id")]
        public string order_id { get; set; }
        [JsonProperty("action")]
        public string action { get; set; }
        [JsonProperty("total_amount")]
        public string total_amount { get; set; }
        [JsonProperty("authorization_code")]
        public string authorization_code { get; set; }
        [JsonProperty("entered_by")]
        public string entered_by { get; set; }
        [JsonProperty("customer_accounting_code")]
        public string customer_accounting_code { get; set; }
        [JsonProperty("sales_tax_amount")]
        public string sales_tax_amount { get; set; }
        [JsonProperty("response_type")]
        public string response_type { get; set; }
        [JsonProperty("response_code")]
        public string response_code { get; set; }
        [JsonProperty("response_desc")]
        public string response_desc { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        public Links links { get; set; }

        public ForteTransaction()
        {
            links = new Links();
        }

    }
}
