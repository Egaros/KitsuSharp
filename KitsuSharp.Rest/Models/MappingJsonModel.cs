using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MappingJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "mappings";

        [JsonProperty("externalSite")]
        public ExternalSite ExternalSite { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }
}