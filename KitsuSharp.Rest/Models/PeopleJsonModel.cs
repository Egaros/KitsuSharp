using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class PeopleJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("image")]
        public string Image;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("malId")]
        public int MalId;
    }
}