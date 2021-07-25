using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MediaReactionVoteJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;
    }
}