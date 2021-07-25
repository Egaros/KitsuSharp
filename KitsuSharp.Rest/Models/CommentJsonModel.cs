using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CommentJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "comments";

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentFormatted")]
        public string ContentFormatted { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("deletedAt")]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("likesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("repliesCount")]
        public int RepliesCount { get; set; }

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt { get; set; }

        [JsonProperty("embed")]
        public string Embed { get; set; }

        [JsonProperty("embedUrl")]
        public string EmbedUrl { get; set; }
    }
}