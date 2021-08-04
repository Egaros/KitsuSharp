namespace KitsuSharp.Rest.Entities
{
    public interface ISiteAnnouncement : IKitsuEntity
    {
        string Title { get; }

        string Description { get; }

        string ImageUrl { get; }

        string Link { get; }
    }
}