using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("animeProductions")]
    public class AnimeProductionJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public ProducerRole Role { get; set; }
    }
}