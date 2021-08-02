using System.Collections.Generic;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("streamingLinks")]
    public class StreamingLinkJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("dubs")]
        public List<string> Dubs { get; set; } = new List<string>();

        [JsonProperty("subs")]
        public List<string> Subs { get; set; } = new List<string>();

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}