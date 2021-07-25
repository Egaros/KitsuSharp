using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum GroupPermission
    {
        [EnumMember(Value = "community")]
        Community,

        [EnumMember(Value = "content")]
        Content,

        [EnumMember(Value = "leaders")]
        Leaders,

        [EnumMember(Value = "owner")]
        Owner,

        [EnumMember(Value = "tickets")]
        Tickets
    }
}