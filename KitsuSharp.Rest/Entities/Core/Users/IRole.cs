namespace KitsuSharp.Rest.Entities
{
    public interface IRole : IKitsuEntity
    {
        string Name { get; }

        string ResourceId { get; }

        string ResourceType { get; }
    }
}