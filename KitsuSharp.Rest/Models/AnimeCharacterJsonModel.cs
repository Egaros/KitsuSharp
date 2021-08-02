using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("animeCharacters")]
    public class AnimeCharacterJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public CharacterRole Role { get; set; }
    }
}