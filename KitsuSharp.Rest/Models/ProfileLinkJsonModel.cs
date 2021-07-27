using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ProfileLinkJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "profileLinks";

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}