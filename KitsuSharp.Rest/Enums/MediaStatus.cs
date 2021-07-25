using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum MediaStatus
    {
        [EnumMember(Value = "tba")]
        ToBeAnnounced,

        [EnumMember(Value = "finished")]
        Finished,

        [EnumMember(Value = "current")]
        Current,

        [EnumMember(Value = "upcoming")]
        Upcoming,

        [EnumMember(Value = "unreleased")]
        Unreleased
    }
}