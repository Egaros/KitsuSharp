using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class StreamerJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "streamers";

        [JsonProperty("siteName")]
        public string SiteName { get; set; }

        [JsonProperty("streamingLinksCount")]
        public int StreamingLinksCount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}