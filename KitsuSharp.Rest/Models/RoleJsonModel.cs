using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("roles")]
    public class RoleJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }
    }
}