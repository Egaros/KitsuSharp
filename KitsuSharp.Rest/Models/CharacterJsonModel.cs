using System;
using KitsuSharp.Models;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CharacterJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("slug")]
        public string Slug;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("malId")]
        public int MalId;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("image")]
        public ImageJsonModel Image;
    }
}