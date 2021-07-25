using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupCategoryJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("slug")]
        public string Slug;

        [JsonProperty("description")]
        public string Description;
    }
}