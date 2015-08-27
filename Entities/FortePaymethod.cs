using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FortePaymethod : ForteEnvironmentDetails
    {
        [JsonProperty("paymethod_token")]
        public string paymethod_token { get; set; }
        [JsonProperty("customer_token")]
        public string customer_token { get; set; }
        [JsonProperty("label")]
        public string label { get; set; }
        [JsonProperty("notes")]
        public string notes { get; set; }
        [JsonProperty("echeck")]
        public Echeck forteEcheck { get; set; }
        [JsonProperty("card")]
        public Card forteCard { get; set; }
        [JsonProperty("links")]
        public Links links { get; set; }

        public FortePaymethod()
        {
            forteEcheck = new Echeck();
            forteCard = new Card();
        }
    }
}
