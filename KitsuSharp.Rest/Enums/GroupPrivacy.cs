using System.Runtime.Serialization;

namespace KitsuSharp.Enums
{
    public enum GroupPrivacy
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "restricted")]
        Restricted
    }
}