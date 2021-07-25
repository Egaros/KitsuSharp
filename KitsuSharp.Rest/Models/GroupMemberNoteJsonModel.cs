using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupMemberNoteJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupMemberNotes";

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentFormatted")]
        public string ContentFormatted { get; set; }
    }
}