using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ListImportStatus
    {
        [EnumMember(Value = "queued")]
        Queued,

        [EnumMember(Value = "running")]
        Running,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "completed")]
        Completed
    }
}