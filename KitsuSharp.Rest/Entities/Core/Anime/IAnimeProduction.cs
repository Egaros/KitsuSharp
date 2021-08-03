using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IAnimeProduction : IKitsuEntity
    {
        ProducerRole Role { get; }
    }
}