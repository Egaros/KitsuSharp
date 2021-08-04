using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupInvite : IKitsuEntity
    {
        DateTimeOffset? AcceptedAt { get; }

        DateTimeOffset? DeclinedAt { get; }

        DateTimeOffset? RevokedAt { get; }
    }
}