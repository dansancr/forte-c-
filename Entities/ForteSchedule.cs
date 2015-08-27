using Newtonsoft.Json;
using System;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteSchedule : ForteEnvironmentDetails
    {
        [JsonProperty("schedule_id")]
        public string ScheduleID
        {
            get;
            set;
        }

        [JsonProperty("account_id")]
        public string AccountID
        {
            get;
            set;
        }

        [JsonProperty("location_id")]
        public string LocationID
        {
            get;
            set;
        }

        [JsonProperty("customer_token")]
        public string CustomerToken
        {
            get;
            set;
        }

        [JsonProperty("paymethod_token")]
        public string PaymethodToken
        {
            get;
            set;
        }

        [JsonProperty("action")]
        public string Action
        {
            get;
            set;
        }

        [JsonProperty("schedule_quantity")]
        public Nullable<int> Quantity
        {
            get;
            set;
        }

        [JsonProperty("schedule_frequency")]
        public string Frequency
        {
            get;
            set;
        }

        [JsonProperty("schedule_amount")]
        public Nullable<double> Amount
        {
            get;
            set;
        }

        [JsonProperty("schedule_created_date")]
        public DateTime? CreatedDate
        {
            get;
            set;
        }

        [JsonProperty("schedule_start_date")]
        public DateTime? StartDate
        {
            get;
            set;
        }

        [JsonProperty("schedule_status")]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty("schedule_source")]
        public string Source
        {
            get;
            set;
        }

        [JsonProperty("customer_acct_code")]
        public string CustomerAcctCode
        {
            get;
            set;
        }

        [JsonProperty("sec_code")]
        public string SecCode
        {
            get;
            set;
        }

        [JsonProperty("item_description")]
        public string ItemDescription
        {
            get;
            set;
        }

        [JsonProperty("reference_id")]
        public string ReferenceId
        {
            get;
            set;
        }

        [JsonProperty("order_number")]
        public string OrderNumber
        {
            get;
            set;
        }

        [JsonProperty("customer_id")]
        public string CustomerId
        {
            get;
            set;
        }

        public Links links { get; set; }

        public ForteSchedule()
        {
            links = new Links();
        }

    }
}
