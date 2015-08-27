using Newtonsoft.Json;

namespace Forte
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Links
    {
        [JsonProperty("self")]
        public string self { get; set; }
        [JsonProperty("next")]
        public string next { get; set; }
        [JsonProperty("previous")]
        public string previous { get; set; }
    }
}
