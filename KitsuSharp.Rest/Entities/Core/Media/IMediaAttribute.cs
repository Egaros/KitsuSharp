namespace KitsuSharp.Rest.Entities
{
    public interface IMediaAttribute : IKitsuEntity
    {
        string Title { get; }

        string HighTitle { get; }

        string NeutralTitle { get; }

        string LowTitle { get; }
    }
}