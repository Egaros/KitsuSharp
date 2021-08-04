using System;
using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroup : IKitsuEntity
    {
        string Slug { get; }

        string About { get; }

        string Locale { get; }

        int MemberCount { get; }

        string Name { get; }

        bool IsNsfw { get; }

        GroupPrivacy Privacy { get; }

        string Rules { get; }

        string FormattedRules { get; }

        int LeaderCount { get; }

        int NeighborCount { get; }

        bool IsFeatures { get; }

        string Tagline { get; }

        DateTimeOffset LastActivityAt { get; }

        IPosterImage Avatar { get; }

        ICoverImage CoverImage { get; }
    }
}