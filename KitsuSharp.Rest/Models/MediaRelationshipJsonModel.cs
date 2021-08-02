using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("mediaRelationships")]
    public class MediaRelationshipJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public MediaRelationRole Role { get; set; }
    }
}