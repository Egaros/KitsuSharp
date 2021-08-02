using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum TitleLanguagePreference
    {
        [EnumMember(Value = "canonical")]
        Canonical,

        [EnumMember(Value = "romanized")]
        Romanized,

        [EnumMember(Value = "english")]
        English
    }
}