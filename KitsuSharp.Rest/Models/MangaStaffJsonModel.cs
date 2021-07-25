using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MangaStaffJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("role")]
        public string Role;
    }
}