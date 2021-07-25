using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CastingJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "animeStaff";

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("voiceActor")]
        public bool VoiceActor { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}