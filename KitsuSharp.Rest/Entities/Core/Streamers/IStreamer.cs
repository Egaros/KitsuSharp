namespace KitsuSharp.Rest.Entities
{
    public interface IStreamer : IKitsuEntity
    {
        string SiteName { get; }

        int StreamingLinksCount { get; }

        string Logo { get; }
    }
}