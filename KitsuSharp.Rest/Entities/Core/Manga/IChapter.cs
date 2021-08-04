using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IChapter : IKitsuEntity, ITitleEntity
    {
        string CanonicalTitle { get; }

        string Description { get; }

        int Length { get; }

        int Number { get; }

        DateTimeOffset PublishedAt { get; }

        IImageEntity Thumbnail { get; }

        int VolumeNumber { get; }
    }
}