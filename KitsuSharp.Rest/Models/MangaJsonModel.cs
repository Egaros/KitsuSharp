using System;
using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("manga")]
    public class MangaJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("abbreviatedTitles")]
        public string[] AbbreviatedTitles { get; set; }

        [JsonProperty("ageRating")]
        public AgeRating AgeRating { get; set; }

        [JsonProperty("ageRatingGuide")]
        public string AgeRatingGuide { get; set; }

        [JsonProperty("averageRating")]
        public string AverageRating { get; set; }

        [JsonProperty("canonicalTitle")]
        public string CanonicalTitle { get; set; }

        [JsonProperty("chapterCount")]
        public int ChapterCount { get; set; }

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset? EndDate;

        [JsonProperty("favoritesCount")]
        public int FavouritesCount { get; set; }

        [JsonProperty("nextRelease")]
        public string NextRelease { get; set; }

        [JsonProperty("popularityRank")]
        public int PopularityRank { get; set; }

        [JsonProperty("posterImage")]
        public ImageJsonModel PosterImage { get; set; }

        [JsonProperty("ratingFrequencies")]
        public RatingFrequenciesJsonModel RatingFrequencies { get; set; }

        [JsonProperty("serialization")]
        public string Serialization { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("status")]
        public MediaStatus Status { get; set; }

        [JsonProperty("subtype")]
        public MangaSubType SubType { get; set; }

        [JsonProperty("tba")]
        public string Tba { get; set; }

        [JsonProperty("titles")]
        public TitleJsonModel Titles { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("volumeCount")]
        public int VolumeCount { get; set; }
    }
}