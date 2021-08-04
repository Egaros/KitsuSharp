using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IComment : IKitsuEntity
    {
        string Content { get; }

        string FormattedContent { get; }

        bool IsBlocked { get; }

        DateTimeOffset? DeletedAt { get; }

        int LikesCount { get; }

        int RepliesCount { get; }

        DateTimeOffset? EditedAt { get; }

        string Embed { get; }

        string EmbedUrl { get; }
    }
}