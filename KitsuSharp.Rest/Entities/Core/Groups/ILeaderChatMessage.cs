using System;

namespace KitsuSharp.Rest.Entities
{
    public interface ILeaderChatMessage : IKitsuEntity
    {
        string Content { get; }

        string FormattedContent { get; }

        DateTimeOffset? EditedAt { get; }
    }
}