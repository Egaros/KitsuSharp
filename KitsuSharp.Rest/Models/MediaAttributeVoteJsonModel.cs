using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    // Still under development API side.
    public class MediaAttributeVoteJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("vote")]
        public string Vote { get; set; }
    }
}