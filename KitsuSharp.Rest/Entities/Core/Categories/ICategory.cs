namespace KitsuSharp.Rest.Entities
{
    public interface ICategory : IKitsuEntity
    {
        string Title { get; }

        string Description { get; }

        int ChildCount { get; }

        IPosterImage Image { get; }

        bool IsNsfw { get; }

        string Slug { get; }

        int TotalMediaCount { get; }
    }
}