using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    public class ChapterJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "chapters";

        [JsonProperty("canonicalTitle")]
        public string CanonicalTitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("published")]
        public DateTimeOffset Published { get; set; }

        [JsonProperty("thumbnail")]
        public ImageJsonModel Thumbnail { get; set; }

        [JsonProperty("titles")]
        public JObject Titles { get; set; }

        [JsonProperty("volumeNumber")]
        public int VolumeNumber { get; set; }
    }
}