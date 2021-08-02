using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum UserTheme
    {
        [EnumMember(Value = "dark")]
        Dark,

        [EnumMember(Value = "light")]
        Light
    }
}