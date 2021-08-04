using System.Collections.Generic;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("streamingLinks")]
    public class StreamingLinkJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("dubs")]
        public string[] Dubs { get; set; }

        [JsonProperty("subs")]
        public string[] Subs { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}