using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class RoleJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "roles";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }
    }
}