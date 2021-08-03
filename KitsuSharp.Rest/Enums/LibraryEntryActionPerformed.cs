using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum LibraryEntryActionPerformed
    {
        [EnumMember(Value = "create")]
        Create,

        [EnumMember(Value = "destroy")]
        Destroy,

        [EnumMember(Value = "update")]
        Update
    }
}