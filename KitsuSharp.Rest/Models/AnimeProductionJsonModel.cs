using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class AnimeProductionJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("role")]
        public ProducerRole Role;
    }
}