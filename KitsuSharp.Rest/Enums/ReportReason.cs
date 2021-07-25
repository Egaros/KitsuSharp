using System.Runtime.Serialization;

namespace KitsuSharp.Enums
{
    public enum ReportReason
    {
        [EnumMember(Value = "nsfw")]
        Nsfw,

        [EnumMember(Value = "offensive")]
        Offensive,

        [EnumMember(Value = "spoiler")]
        Spoiler,

        [EnumMember(Value = "bullying")]
        Bullying,

        [EnumMember(Value = "other")]
        Other,

        [EnumMember(Value = "spam")]
        Spam
    }
}