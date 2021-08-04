using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupPermission : IKitsuEntity
    {
        GroupPermission Permission { get; }
    }
}