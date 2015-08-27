using Newtonsoft.Json;
using System;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteScheduleItem : ForteEnvironmentDetails
    {
        [JsonProperty("schedule_item_id")]
        public string ScheduleItemID
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

        [JsonProperty("schedule_id")]
        public string ScheduleID
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_amount")]
        public Nullable<double> Amount
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_status")]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_date")]
        public DateTime? ScheduleDate
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_processed_date")]
        public DateTime? ProcessedDate
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_created_date")]
        public DateTime? CreatedDate
        {
            get;
            set;
        }

        [JsonProperty("schedule_item_description")]
        public string ItemDescription
        {
            get;
            set;
        }

        public Links links { get; set; }

        public ForteScheduleItem()
        {
            links = new Links();
        }

    }
}
