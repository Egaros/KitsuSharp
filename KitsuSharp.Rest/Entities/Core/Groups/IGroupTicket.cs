using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupTicket : IKitsuEntity
    {
        GroupTicketStatus Status { get; }
    }
}