using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ReportStatus
    {
        [EnumMember(Value = "reported")]
        Reported,

        [EnumMember(Value = "resolved")]
        Resolved,

        [EnumMember(Value = "declined")]
        Declined,

        [EnumMember(Value = "escalated")]
        Escalated
    }
}