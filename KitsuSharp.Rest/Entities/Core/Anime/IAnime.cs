using System;
using System.Collections.Generic;
using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IAnime : IKitsuEntity, ITitleEntity
    {
        IReadOnlyList<string> AbbreviatedTitles { get; }

        AgeRating AgeRating { get; }

        string AgeRatingGuide { get; }

        string AverageRating { get; }

        string CanonicalTitle { get; }

        ICoverImage CoverImage { get; }

        string Description { get; }

        DateTimeOffset? EndDate { get; }

        int? EpisodeCount { get; }

        int? EpisodeLength { get; }

        int? FavouritesCount { get; }

        string NextRelease { get; }

        bool IsNsfw { get; }

        int PopularityRank { get; }

        IPosterImage PosterImage { get; }

        // TODO Put rating entity here as well

        int RatingRank { get; }

        string Slug { get; }

        DateTimeOffset? StartDate { get; set; }

        MediaStatus Status { get; }

        AnimeSubType SubType { get; }

        string Tba { get; }

        int? TotalLength { get; }

        int UserCount { get; }

        string YoutubeVideoId { get; }
    }
}