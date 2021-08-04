namespace KitsuSharp.Rest.Entities
{
    public interface IPeople : IKitsuEntity
    {
        string Image { get; }

        string Name { get; }

        int MalId { get; }
    }
}