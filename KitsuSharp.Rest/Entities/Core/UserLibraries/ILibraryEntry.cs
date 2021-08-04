using System;
using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface ILibraryEntry : IKitsuEntity
    {
        LibraryEntryStatus Status { get; }

        int Progress { get; }

        int VolumesOwned { get; }

        bool IsReconsuming { get; }

        int ReconsumeCount { get; }

        string Notes { get; }

        bool IsPrivate { get; }

        ReactionSkipped ReactionSkipped { get; }

        DateTimeOffset ProgressedAt { get; }

        DateTimeOffset StartedAt { get; }

        DateTimeOffset EndedAt { get; }

        int Rating { get; }
    }
}