using System.Collections.Generic;

namespace KitsuSharp.Rest.Entities
{
    public interface IUserLinkedAccount : IKitsuEntity
    {
        string Kind { get; }

        bool SharesFrom { get; }

        bool SharesTo { get; }

        bool SyncTo { get; }

        string ExternalId { get; }
    }

    public interface ILinkedAccountToken
    {
        ulong CreatedAt { get; }

        string Uid { get; }

        ulong ExpiresInSeconds { get; }

        int ResourceOwnerId { get; }

        IReadOnlyList<string> Scoped { get; }
    }
}