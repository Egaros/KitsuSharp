using System;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("posts")]
    public class PostJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonProperty("postLikesCount")]
        public int PostLikesCount { get; set; }

        [JsonProperty("spoiler")]
        public bool Spoiler { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("deletedAt")]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("topLevelCommentsCount")]
        public int TopLevelCommentsCount { get; set; }

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt { get; set; }

        [JsonProperty("targetInterest")]
        public string TargetInterest { get; set; }

        [JsonProperty("embed")]
        public string Embed { get; set; }

        [JsonProperty("embedUrl")]
        public string EmbedUrl { get; set; }
    }
}