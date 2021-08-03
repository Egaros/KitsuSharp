using System;
using JsonApiSerializer;
using JsonApiSerializer.JsonApi;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("anime")]
    public class AnimeJsonModel : ResourceBaseJsonModel
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

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("episodeCount")]
        public int? EpisodeCount { get; set; }

        [JsonProperty("episodeLength")]
        public int? EpisodeLength { get; set; }

        [JsonProperty("favoritesCount")]
        public int? FavouritesCount { get; set; }

        [JsonProperty("nextRelease")]
        public string NextRelease { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("popularityRank")]
        public int PopularityRank { get; set; }

        [JsonProperty("posterImage")]
        public ImageJsonModel PosterImage { get; set; }

        [JsonProperty("ratingFrequencies")]
        public RatingFrequenciesJsonModel RatingFrequencies { get; set; }

        [JsonProperty("ratingRank")]
        public int RatingRank { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("status")]
        public MediaStatus Status { get; set; }

        [JsonProperty("subtype")]
        public AnimeSubType SubType { get; set; }

        [JsonProperty("tba")]
        public string Tba { get; set; }

        [JsonProperty("titles")]
        public TitleJsonModel Titles { get; set; }

        [JsonProperty("totalLength")]
        public int? TotalLength { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("youtubeVideoId")]
        public string YoutubeVideoId { get; set; }

        public Relationship<EpisodeJsonModel[]> Episodes { get; set; }
    }
}