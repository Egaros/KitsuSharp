using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    // In development API side.
    [ResourceType("libraryEvents")]
    public class LibraryEventJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("reconsuming")]
        public bool Reconsuming { get; set; }

        [JsonProperty("reconsumeCount")]
        public int ReconsumeCount { get; set; }

        [JsonProperty("timeSpent")]
        public int TimeSpent { get; set; }

        [JsonProperty("status")]
        public LibraryEventStatus Status { get; set; }

        [JsonProperty("event")]
        public LibraryEvent Event { get; set; }

        [JsonProperty("changedData")]
        public JObject ChangedData { get; set; }
    }
}