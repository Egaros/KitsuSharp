using System;
using Newtonsoft.Json;

namespace KitsuSharp.Models
{
    public class CommentJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("content")]
        public string Content;

        [JsonProperty("contentFormatted")]
        public string ContentFormatted;

        [JsonProperty("blocked")]
        public bool Blocked;

        [JsonProperty("deletedAt")]
        public DateTimeOffset? DeletedAt;

        [JsonProperty("likesCount")]
        public int LikesCount;

        [JsonProperty("repliesCount")]
        public int RepliesCount;

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt;

        [JsonProperty("embed")]
        public string Embed;

        [JsonProperty("embedUrl")]
        public string EmbedUrl;
    }
}