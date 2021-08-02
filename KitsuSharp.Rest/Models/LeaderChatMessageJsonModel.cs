using System;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("leaderChatMessages")]
    public class LeaderChatMessageJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentFormatted")]
        public string ContentFormatted { get; set; }

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt { get; set; }
    }
}