using System;
using System.Collections.Generic;
using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IManga : IKitsuEntity
    {
        IReadOnlyList<string> AbbreviatedTitles { get; }

        AgeRating AgeRating { get; }

        string AgeRatingGuide { get; }

        string AverageRating { get; }

        string CanonicalTitle { get; }

        int ChapterCount { get; }

        ICoverImage CoverImage { get; }

        string Description { get; }

        DateTimeOffset? EndDate { get; }

        int FavouritesCount { get; }

        string NextRelease { get; }

        int PopularityRank { get; }

        IPosterImage PosterImage { get; }

        // TODO Add Ratings

        string Serialization { get; }

        string Slug { get; }

        DateTimeOffset StartDate { get; }

        MediaStatus Status { get; }

        MangaSubType SubType { get; }

        string Tba { get; }

        ITitle Titles { get; }

        int UserCount { get; }

        int VolumeCount { get; }
    }
}