using System.Collections.Generic;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class StreamingLinkJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "streamingLinks";

        [JsonProperty("dubs")]
        public List<string> Dubs { get; set; } = new List<string>();

        [JsonProperty("subs")]
        public List<string> Subs { get; set; } = new List<string>();

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}