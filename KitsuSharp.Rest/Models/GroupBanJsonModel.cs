using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupBans")]
    public class GroupBanJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notesFormatted")]
        public string NotesFormatted { get; set; }
    }
}