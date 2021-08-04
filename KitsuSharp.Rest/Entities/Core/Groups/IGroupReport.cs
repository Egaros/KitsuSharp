using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupReport : IKitsuEntity
    {
        ReportReason Reason { get; }

        ReportStatus Status { get; }

        string Explanation { get; }

        string NaughtyType { get; }

        int NaughtyId { get; }
    }
}