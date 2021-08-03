using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum AnimeSubType
    {
        [EnumMember(Value = "ONA")]
        Ona,

        [EnumMember(Value = "OVA")]
        Ova,

        [EnumMember(Value = "TV")]
        Tv,

        [EnumMember(Value = "movie")]
        Movie,

        [EnumMember(Value = "music")]
        Music,

        [EnumMember(Value = "special")]
        Special
    }
}