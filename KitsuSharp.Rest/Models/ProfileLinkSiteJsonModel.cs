using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("profileLinkSites")]
    public class ProfileLinkSiteJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}