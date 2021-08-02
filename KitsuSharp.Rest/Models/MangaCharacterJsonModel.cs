using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("mangaCharacters")]
    public class MangaCharacterJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public CharacterRole Role { get; set; }
    }
}