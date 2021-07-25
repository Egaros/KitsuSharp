using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MangaCharacterJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "mangaCharacters";

        [JsonProperty("role")]
        public CharacterRole Role { get; set; }
    }
}