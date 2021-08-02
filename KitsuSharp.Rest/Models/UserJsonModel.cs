using System;
using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("users")]
    public class UserJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pastNames")]
        public string[] PastNames { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("waifuOrHusbando")]
        public string WaifuOrHusbando { get; set; }

        [JsonProperty("followersCount")]
        public int FollowersCount { get; set; }

        [JsonProperty("followingCount")]
        public int FollowingCount { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonProperty("favoritesCount")]
        public int FavoritesCount { get; set; }

        [JsonProperty("likesGivenCount")]
        public int LikesGivenCount { get; set; }

        [JsonProperty("reviewsCount")]
        public int ReviewsCount { get; set; }

        [JsonProperty("likesReceivedCount")]
        public int LikesReceivedCount { get; set; }

        [JsonProperty("postsCount")]
        public int PostsCount { get; set; }

        [JsonProperty("ratingsCount")]
        public int RatingsCount { get; set; }

        [JsonProperty("mediaReactionsCount")]
        public int MediaReactionsCount { get; set; }

        [JsonProperty("proExpiresAt")]
        public DateTimeOffset? ProExpiresAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("profileCompleted")]
        public bool ProfileCompleted { get; set; }

        [JsonProperty("feedCompleted")]
        public bool FeedCompleted { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("proTier")]
        public string ProTier { get; set; }

        [JsonProperty("avatar")]
        public ImageJsonModel Avatar { get; set; }

        [JsonProperty("coverImage")]
        public ImageJsonModel CoverImage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        //[JsonProperty("password")]
        //public string Password { get; set; }

        [JsonProperty("confirmed")]
        public string Confirmed { get; set; }

        [JsonProperty("previousEmail")]
        public string Previous { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("shareToGlobal")]
        public bool? ShareToGlobal { get; set; }

        [JsonProperty("titleLanguagePreference")]
        public TitleLanguagePreference TitleLanguagePreference { get; set; }

        [JsonProperty("sfwFilter")]
        public bool? SfwFilter { get; set; }

        [JsonProperty("ratingSystem")]
        public RatingSystem RatingSystem { get; set; }

        [JsonProperty("theme")]
        public UserTheme UserTheme { get; set; }

        [JsonProperty("facebookId")]
        public string FacebookId { get; set; }

        [JsonProperty("hasPassword")]
        public bool HasPassword { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("subscribedToNewsletter")]
        public bool SubscribedToNewsletter { get; set; }

        [JsonProperty("aoPro")]
        public string AoPro { get; set; }
    }
}