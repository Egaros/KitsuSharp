using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum CharacterRole
    {
        [EnumMember(Value = "main")]
        Main,

        [EnumMember(Value = "supporting")]
        Supporting
    }
}