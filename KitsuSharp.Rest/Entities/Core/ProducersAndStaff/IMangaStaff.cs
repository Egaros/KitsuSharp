using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IMangaStaff : IKitsuEntity
    {
        ProducerRole Role { get; }
    }
}