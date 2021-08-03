using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum LibraryEntrySyncStatus
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "error")]
        Error
    }
}