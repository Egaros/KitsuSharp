using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum StatKind
    {
        [EnumMember(Value = "anime-activity-history")]
        AnimeActivityHistory,

        [EnumMember(Value = "anime-amount-consumed")]
        AnimeAmountConsumed,

        [EnumMember(Value = "anime-category-breakdown")]
        AnimeCategoryBreakdown,

        [EnumMember(Value = "anime-favorite-year")]
        AnimeFavoriteYear,

        [EnumMember(Value = "manga-activity-history")]
        MangaActivityHistory,

        [EnumMember(Value = "manga-amount-consumed")]
        MangaAmountConsumed,

        [EnumMember(Value = "manga-category-breakdown")]
        MangaCategoryBreakdown,

        [EnumMember(Value = "anime-favorite-year")]
        MangaFavouriteYear
    }
}