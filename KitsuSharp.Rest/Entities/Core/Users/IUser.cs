using System;
using System.Collections.Generic;
using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IUser : IKitsuEntity
    {
        string Name { get; }

        IReadOnlyList<string> PastNames { get; }

        string Slug { get; }

        string About { get; }

        string Location { get; }

        bool IsWaifu { get; }

        bool IsHusbando { get; }

        int FollowerCount { get; }

        int FollowingCount { get; }

        string Birthday { get; }

        string Gender { get; }

        int CommentsCount { get; }

        int FavoritesCount { get; }

        int LikesGivenCount { get; }

        int ReviewsCount { get; }

        int LikesReceivedCount { get; }

        int PostsCount { get; }

        int RatingsCount { get; }

        int MediaReactionCount { get; }

        DateTimeOffset? ProExpiresAt { get; }

        string Title { get; }

        bool IsProfileCompleted { get; }

        bool IsFeedCompleted { get; }

        string ProTier { get; }

        IPosterImage Avatar { get; }

        ICoverImage CoverImage { get; }

        string Email { get; }

        string Password { get; }

        bool IsConfirmed { get; }

        string  PreviousEmail { get; }

        string Language { get; }

        string TimeZone { get; }

        string Country { get; }

        bool SharesToGlobal { get; }

        TitleLanguagePreference TitleLanguagePreference { get; }

        bool FilterNsfw { get; }

        RatingSystem RatingSystem { get; }

        UserTheme Theme { get; }

        string FacebookId { get; }

        bool HasPassword { get; }

        string Status { get; }

        bool IsSubscribedToNewsletter { get; }

        string AoPro { get; }
    }
}