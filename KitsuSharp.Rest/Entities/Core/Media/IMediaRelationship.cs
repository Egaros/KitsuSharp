using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IMediaRelationship : IKitsuEntity
    {
        MediaRelationRole Role { get; }
    }
}