using Newtonsoft.Json;

namespace ForteSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteCard
    {
        [JsonProperty("card_type")]
        public string card_type
        {
            get;
            set;
        }

        [JsonProperty("name_on_card")]
        public string name_on_card
        {
            get;
            set;
        }

        [JsonProperty("account_number")]
        public string account_number
        {
            get;
            set;
        }

        [JsonProperty("masked_account_number")]
        public string masked_account_number
        {
            get;
            set;
        }

        [JsonProperty("expire_month")]
        public string expire_month
        {
            get;
            set;
        }

        [JsonProperty("expire_year")]
        public string expire_year
        {
            get;
            set;
        }

        [JsonProperty("card_verification_value")]
        public string card_verification_value
        {
            get;
            set;
        }

        [JsonProperty("procurement_card")]
        public string procurement_card
        {
            get;
            set;
        }

        [JsonProperty("customer_accounting_code")]
        public string customer_accounting_code
        {
            get;
            set;
        }

        [JsonProperty("one_time_token")]
        public string one_time_token
        {
            get;
            set;
        }

        [JsonProperty("suppress_account_updater")]
        public string suppress_account_updater
        {
            get;
            set;
        }

        [JsonProperty("au_code")]
        public string au_code
        {
            get;
            set;
        }

        [JsonProperty("au_updated_date")]
        public string au_updated_date
        {
            get;
            set;
        }

        [JsonProperty("au_description")]
        public string au_description
        {
            get;
            set;
        }

    }
}
