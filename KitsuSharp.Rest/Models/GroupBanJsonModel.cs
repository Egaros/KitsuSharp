using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupBanJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("notes")]
        public string Notes;

        [JsonProperty("notesFormatted")]
        public string NotesFormatted;
    }
}