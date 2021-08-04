using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface ILibraryEntryLog : IKitsuEntity
    {
        int Progress { get; }

        int Rating { get; }

        int ReconsumeCount { get; }

        bool IsReconsuming { get; }

        LibraryEntryStatus Status { get; }

        int VolumesOwned { get; }

        LibraryEntryActionPerformed ActionPerformed { get; }

        LibraryEntrySyncStatus SyncStatus { get; }

        string ErrorMessage { get; }
    }
}