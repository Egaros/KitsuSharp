using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class LeaderChatMessageJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("content")]
        public string Content;

        [JsonProperty("contentFormatted")]
        public string ContentFormatted;

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt;
    }
}