using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("libraryEntryLogs")]
    public class LibraryEntryLogJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("reconsuming")]
        public bool Reconsuming { get; set; }

        [JsonProperty("reconsumeCount")]
        public int ReconsumeCount { get; set; }

        [JsonProperty("status")]
        public LibraryEntryStatus Status { get; set; }

        [JsonProperty("volumesOwned")]
        public int VolumesOwned { get; set; }

        [JsonProperty("actionPerformed")]
        public LibraryEntryActionPerformed ActionPerformed { get; set; }

        [JsonProperty("syncStatus")]
        public LibraryEntrySyncStatus SyncStatus { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}