using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForteSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ForteListResult<T> where T : class, new()
    {
        [JsonProperty("number_results")]
        public string number_results
        {
            get;
            set;
        }

        [JsonProperty("search_criteria")]
        public ForteSearchCriteria search_criteria
        {
            get;
            set;
        }

        [JsonProperty("results")]
        public IEnumerable<T> results
        {
            get;
            set;
        }

        [JsonProperty("response")]
        public ForteResponse response
        {
            get;
            set;
        }

        [JsonProperty("links")]
        public ForteLinks links
        {
            get;
            set;
        }

        public ForteListResult()
        {
            search_criteria = new ForteSearchCriteria();
            response = new ForteResponse();
            links = new ForteLinks();
        }
    }
}
