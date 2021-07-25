using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ResourceBaseJsonModel
    {
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}