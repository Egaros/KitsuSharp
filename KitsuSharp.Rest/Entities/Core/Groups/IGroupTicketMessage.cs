using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupTicketMessage : IKitsuEntity
    {
        GroupTicketMessageKind Kind { get; }

        string Content { get; }
    }
}