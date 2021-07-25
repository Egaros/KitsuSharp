using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class LeaderChatMessageJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "leaderChatMessages";

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentFormatted")]
        public string ContentFormatted { get; set; }

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt { get; set; }
    }
}