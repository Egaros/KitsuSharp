using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupActionLogJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("verb")]
        public string Verb;
    }
}