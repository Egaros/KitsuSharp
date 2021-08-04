namespace KitsuSharp.Rest.Entities
{
    public interface ICharacter : IKitsuEntity
    {
        string Slug { get; }

        string Name { get; }

        int MalId { get; }

        string Description { get; }

        IImageEntity Image { get; }
    }
}