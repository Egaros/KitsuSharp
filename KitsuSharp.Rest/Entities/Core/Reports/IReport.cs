using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IReport : IKitsuEntity
    {
        ReportReason Reason { get; }

        ReportStatus Status { get; }

        string Explanation { get; }

        string NaughtyType { get; }

        string NaughtyId { get; }
    }
}