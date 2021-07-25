using System.Runtime.Serialization;

namespace KitsuSharp.Enums
{
    public enum GroupTicketMessageKind
    {
        [EnumMember(Value = "message")]
        Message,

        [EnumMember(Value = "mod_note")]
        ModNote
    }
}