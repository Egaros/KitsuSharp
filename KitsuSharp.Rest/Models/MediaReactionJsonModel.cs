using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("mediaReactions")]
    public class MediaReactionJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("reaction")]
        public string Reaction { get; set; }

        [JsonProperty("upVotesCount")]
        public int UpVotesCount { get; set; }
    }
}