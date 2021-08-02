using System;
using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("libraryEntries")]
    public class LibraryEntryJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("status")]
        public LibraryEntryStatus Status { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("volumesOwned")]
        public int VolumesOwned { get; set; }

        [JsonProperty("reconsuming")]
        public bool Reconsuming { get; set; }

        [JsonProperty("reconsumeCount")]
        public int ReconsumeCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("reactionSkipped")]
        public ReactionSkipped ReactionSkipped { get; set; }

        [JsonProperty("progressedAt")]
        public DateTimeOffset ProgressedAt { get; set; }

        [JsonProperty("startedAt")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonProperty("finishedAt")]
        public DateTimeOffset FinishedAt { get; set; }

        [JsonProperty("ratingTwenty")]
        public int RatingTwenty { get; set; }
    }
}