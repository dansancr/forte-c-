using Newtonsoft.Json;

namespace ForteSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FortePaymethod : ForteResourceClass
    {
        [JsonProperty("organization_id")]
        public string organization_id
        {
            get;
            set;
        }

        [JsonProperty("location_id")]
        public string location_id
        {
            get;
            set;
        }

        [JsonProperty("customer_token")]
        public string customer_token
        {
            get;
            set;
        }

        [JsonProperty("paymethod_token")]
        public string paymethod_token
        {
            get;
            set;
        }

        [JsonProperty("label")]
        public string label
        {
            get;
            set;
        }

        [JsonProperty("card")]
        public ForteCard card
        {
            get;
            set;
        }

        [JsonProperty("echeck")]
        public ForteEcheck echeck
        {
            get;
            set;
        }

        [JsonProperty("notes")]
        public string notes
        {
            get;
            set;
        }

        public FortePaymethod()
        {
            echeck = new ForteEcheck();
            card = new ForteCard();
            links = new ForteLinks();
            response = new ForteResponse();
        }
    }
}
