using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class AnimeCharacterJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "animeCharacters";

        [JsonProperty("role")]
        public CharacterRole Role { get; set; }
    }
}