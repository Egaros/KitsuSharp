using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IEpisode : IKitsuEntity, ITitleEntity
    {
        DateTimeOffset? AirDate { get; }

        string CanonicalTitle { get; }

        string Description { get; }

        int? Length { get; }

        int? RelativeNumber { get; }

        int? SeasonNumber { get; }

        IImageEntity Thumbnail { get; }
    }
}