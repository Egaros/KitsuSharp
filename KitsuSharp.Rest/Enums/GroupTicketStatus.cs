using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum GroupTicketStatus
    {
        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "assigned")]
        Assigned,

        [EnumMember(Value = "resolved")]
        Resolved
    }
}