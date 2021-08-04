using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface ILibraryEvent : IKitsuEntity
    {
        string Notes { get; }

        bool IsNsfw { get; }

        bool IsPrivate { get; }

        int Progress { get; }

        int Rating { get; }

        bool IsReconsuming { get; }

        int ReconsumeCount { get; }

        int VolumesOwned { get; }

        int TimeSpent { get; }

        LibraryEntryStatus Status { get; }

        LibraryEvent Event { get; }
    }
}