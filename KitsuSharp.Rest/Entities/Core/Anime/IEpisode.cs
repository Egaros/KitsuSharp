using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IEpisode : IKitsuEntity
    {
        DateTimeOffset? AirDate { get; }

        string CanonicalTitle { get; }

        string Description { get; }

        int? Length { get; }

        int? RelativeNumber { get; }

        int? SeasonNumber { get; }

        IImageEntity Thumbnail { get; }

        ITitle Titles { get; }
    }
}