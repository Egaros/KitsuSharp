using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IMapping : IKitsuEntity
    {
        ExternalSite ExternalSite { get; }

        string ExternalId { get; }
    }
}