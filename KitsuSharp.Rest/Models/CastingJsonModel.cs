using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CastingJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("role")]
        public string Role;

        [JsonProperty("voiceActor")]
        public bool VoiceActor;

        [JsonProperty("featured")]
        public bool Featured;

        [JsonProperty("language")]
        public string Language;
    }
}