using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    public class EpisodeJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "episodes";

        [JsonProperty("airdate")]
        public DateTimeOffset? AirDate { get; set; }

        [JsonProperty("canonicalTitle")]
        public string CanonicalTitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("relativeNumber")]
        public int? RelativeNumber { get; set; }

        [JsonProperty("seasonNumber")]
        public int? SeasonNumber { get; set; }

        [JsonProperty("thumbnail")]
        public ImageJsonModel Thumbnail { get; set; }

        [JsonProperty("titles")]
        public JObject Titles { get; set; }
    }
}