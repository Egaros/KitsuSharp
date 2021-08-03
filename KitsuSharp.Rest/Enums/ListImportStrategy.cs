using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ListImportStrategy
    {
        [EnumMember(Value = "greater")]
        Greater,

        [EnumMember(Value = "obliterate")]
        Obliterate,
    }
}