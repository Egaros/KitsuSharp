using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum RatingSystem
    {
        [EnumMember(Value = "advanced")]
        Advanced,

        [EnumMember(Value = "regular")]
        Regular,

        [EnumMember(Value = "simple")]
        Simple
    }
}