namespace KitsuSharp.Rest.Entities
{
    public interface IGroupCategory : IKitsuEntity
    {
        string Name { get; }

        string Slug { get; }

        string Description { get; }
    }
}