using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MangaCharacterJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("role")]
        public CharacterRole Role;
    }
}