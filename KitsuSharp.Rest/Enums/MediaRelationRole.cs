using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum MediaRelationRole
    {
        [EnumMember(Value = "adaptation")]
        Adaptation,

        [EnumMember(Value = "alternative_setting")]
        AlternativeSetting,

        [EnumMember(Value = "alternative_version")]
        AlternativeVersion,

        [EnumMember(Value = "character")]
        Character,

        [EnumMember(Value = "full_story")]
        FullStory,

        [EnumMember(Value = "other")]
        Other,

        [EnumMember(Value = "parent_story")]
        ParentStory,

        [EnumMember(Value = "prequel")]
        Prequel,

        [EnumMember(Value = "sequel")]
        Sequel,

        [EnumMember(Value = "side_story")]
        SideStory,

        [EnumMember(Value = "spinoff")]
        Spinoff,

        [EnumMember(Value = "summary")]
        Summary
    }
}