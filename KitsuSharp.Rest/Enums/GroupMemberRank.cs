using System.Runtime.Serialization;

namespace KitsuSharp.Enums
{
    public enum GroupMemberRank
    {
        [EnumMember(Value = "admin")]
        Admin,

        [EnumMember(Value = "mod")]
        Mod,

        [EnumMember(Value = "pleb")]
        Pleb
    }
}