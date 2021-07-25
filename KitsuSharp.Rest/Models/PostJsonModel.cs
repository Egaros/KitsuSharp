using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class PostJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("content")]
        public string Content;

        [JsonProperty("commentsCount")]
        public int CommentsCount;

        [JsonProperty("postLikesCount")]
        public int PostLikesCount;

        [JsonProperty("spoiler")]
        public bool Spoiler;

        [JsonProperty("nsfw")]
        public bool Nsfw;

        [JsonProperty("blocked")]
        public bool Blocked;

        [JsonProperty("deletedAt")]
        public DateTimeOffset? DeletedAt;

        [JsonProperty("topLevelCommentsCount")]
        public int TopLevelCommentsCount;

        [JsonProperty("editedAt")]
        public DateTimeOffset? EditedAt;

        [JsonProperty("targetInterest")]
        public string TargetInterest;

        [JsonProperty("embed")]
        public string Embed;

        [JsonProperty("embedUrl")]
        public string EmbedUrl;
    }
}