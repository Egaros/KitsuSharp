using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ProducerJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("slug")]
        public string Slug;

        [JsonProperty("name")]
        public string Name;
    }
}