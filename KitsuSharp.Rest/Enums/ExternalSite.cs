using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ExternalSite
    {
        [EnumMember(Value = "anidb")]
        AniDb,

        [EnumMember(Value = "myanimelist/manga")]
        MyAnimeListManga,

        [EnumMember(Value = "myanimelist/anime")]
        MyAnimeListAnime,

        [EnumMember(Value = "anilist/manga")]
        AniListManga,

        [EnumMember(Value = "anilist/anime")]
        AniListAnime,

        [EnumMember(Value = "thetvdb/season")]
        TheTvDbSeason,

        [EnumMember(Value = "thetvdb/series")]
        TheTvDbSeries
    }
}