using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("profileLinks")]
    public class ProfileLinkJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}