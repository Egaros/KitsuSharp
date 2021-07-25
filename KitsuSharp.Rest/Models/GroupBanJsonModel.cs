using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupBanJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupBans";

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notesFormatted")]
        public string NotesFormatted { get; set; }
    }
}