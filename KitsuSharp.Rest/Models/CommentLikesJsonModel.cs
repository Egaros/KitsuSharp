using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CommentLikesJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;
    }
}