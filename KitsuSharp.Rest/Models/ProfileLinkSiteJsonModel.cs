using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ProfileLinkSiteJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "profileLinkSites";

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}