using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MediaReactionJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("reaction")]
        public string Reaction;

        [JsonProperty("upVotesCount")]
        public int UpVotesCount;
    }
}