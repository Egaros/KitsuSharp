using System;
using JsonApiSerializer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("chapters")]
    public class ChapterJsonModel : ResourceBaseJsonModel
    {
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
        public TitleJsonModel Titles { get; set; }

        [JsonProperty("volumeNumber")]
        public int VolumeNumber { get; set; }
    }
}