using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum LibraryEventStatus
    {
        [EnumMember(Value = "completed")]
        Completed,

        [EnumMember(Value = "current")]
        Current,

        [EnumMember(Value = "dropped")]
        Dropped,

        [EnumMember(Value = "on_hold")]
        OnHold,

        [EnumMember(Value = "planned")]
        Planned
    }
}