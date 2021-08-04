using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IPost : IKitsuEntity
    {
        string Content { get; }

        string FormattedContent { get; }

        int CommentsCount { get; }

        int PostLikesCount { get; }

        bool IsSpoiler { get; }

        bool IsNsfw { get; }

        bool IsBlocked { get; }

        DateTimeOffset? DeletedAt { get; }

        int TopLevelCommentsCount { get; }

        DateTimeOffset? EditedAt { get; }

        string TargetInterest { get; }

        string Embed { get; }

        string EmbedUrl { get; }
    }
}