using System;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    public class MangaJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "manga";

        [JsonProperty("abbreviatedTitles")]
        public string[] AbbreviatedTitles;

        [JsonProperty("ageRating")]
        public AgeRating AgeRating;

        [JsonProperty("ageRatingGuide")]
        public string AgeRatingGuide;

        [JsonProperty("averageRating")]
        public string AverageRating;

        [JsonProperty("canonicalTitle")]
        public string CanonicalTitle;

        [JsonProperty("chapterCount")]
        public int ChapterCount;

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate;

        [JsonProperty("favoritesCount")]
        public int FavouritesCount;

        [JsonProperty("nextRelease")]
        public string NextRelease;

        [JsonProperty("popularityRank")]
        public int PopularityRank;

        [JsonProperty("posterImage")]
        public ImageJsonModel PosterImage;

        [JsonProperty("ratingFrequencies")]
        public RatingFrequenciesJsonModel RatingFrequencies;

        [JsonProperty("serialization")]
        public string Serialization;

        [JsonProperty("slug")]
        public string Slug;

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate;

        [JsonProperty("status")]
        public MediaStatus Status;

        [JsonProperty("subtype")]
        public MangaSubType SubType;

        [JsonProperty("tba")]
        public string Tba;

        [JsonProperty("titles")]
        public JObject Titles;

        [JsonProperty("userCount")]
        public int UserCount;

        [JsonProperty("volumeCount")]
        public int VolumeCount;
    }
}