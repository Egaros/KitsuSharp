using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum LibraryEvent
    {
        [EnumMember(Value = "added")]
        Added,

        [EnumMember(Value = "updated")]
        Updated
    }
}