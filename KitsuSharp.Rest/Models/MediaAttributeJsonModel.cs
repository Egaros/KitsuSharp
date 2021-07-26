using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    // Still under development API side.
    public class MediaAttributeJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("highTitle")]
        public string HighTitle { get; set; }

        [JsonProperty("neutralTitle")]
        public string NeutralTitle { get; set; }

        [JsonProperty("lowTitle")]
        public string LowTitle { get; set; }
    }
}