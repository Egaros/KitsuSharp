using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("mappings")]
    public class MappingJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("externalSite")]
        public ExternalSite ExternalSite { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }
}