using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MediaRelationshipJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "mediaRelationships";

        [JsonProperty("role")]
        public MediaRelationRole Role { get; set; }
    }
}