using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MediaReactionJsonModel
    {
        public static readonly string Type = "mediaReactions";

        [JsonProperty("reaction")]
        public string Reaction { get; set; }

        [JsonProperty("upVotesCount")]
        public int UpVotesCount { get; set; }
    }
}