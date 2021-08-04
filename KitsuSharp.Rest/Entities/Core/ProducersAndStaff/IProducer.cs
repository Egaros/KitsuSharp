namespace KitsuSharp.Rest.Entities
{
    public interface IProducer : IKitsuEntity
    {
        string Slug { get; }

        string Name { get; }
    }
}