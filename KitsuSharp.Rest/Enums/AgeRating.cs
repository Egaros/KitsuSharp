using System.Runtime.Serialization;

namespace KitsuSharp.Rest
{
    public enum AgeRating
    {
        [EnumMember(Value = "G")]
        G,

        [EnumMember(Value = "PG")]
        PG,

        [EnumMember(Value = "R")]
        R,

        [EnumMember(Value = "R18")]
        R18
    }
}