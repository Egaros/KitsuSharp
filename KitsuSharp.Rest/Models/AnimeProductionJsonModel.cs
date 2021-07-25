using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class AnimeProductionJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "animeProductions";

        [JsonProperty("role")]
        public ProducerRole Role { get; set; }
    }
}