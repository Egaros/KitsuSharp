using System.Runtime.Serialization;

namespace KitsuSharp.Rest
{
    public enum MangaSubType
    {
        [EnumMember(Value = "manga")]
        Manga,

        [EnumMember(Value = "manhwa")]
        Manhwa,

        [EnumMember(Value = "manhua")]
        Manhua,

        [EnumMember(Value = "novel")]
        Novel,

        [EnumMember(Value = "oneshot")]
        OneShot,

        [EnumMember(Value = "doujin")]
        Doujin,

        [EnumMember(Value = "oel")]
        Oel
    }
}