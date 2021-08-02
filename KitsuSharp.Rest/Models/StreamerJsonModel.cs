using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("streamers")]
    public class StreamerJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("siteName")]
        public string SiteName { get; set; }

        [JsonProperty("streamingLinksCount")]
        public int StreamingLinksCount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}