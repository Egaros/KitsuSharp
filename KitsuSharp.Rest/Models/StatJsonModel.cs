using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    // Still in development API side.
    [ResourceType("stats")]
    public class StatJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("kind")]
        public StatKind Kind { get; set; }

        [JsonProperty("statsData")]
        public StatDataJsonModel StatData { get; set; }
    }
}