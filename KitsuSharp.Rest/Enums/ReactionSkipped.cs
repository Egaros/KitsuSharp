using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ReactionSkipped
    {
        [EnumMember(Value = "unskipped")]
        Unskipped,

        [EnumMember(Value = "skipped")]
        Skipped,

        [EnumMember(Value = "ignored")]
        Ignored
    }
}