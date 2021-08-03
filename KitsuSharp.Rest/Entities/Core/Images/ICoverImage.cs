namespace KitsuSharp.Rest.Entities
{
    public interface ICoverImage : IImageEntity
    {
        string Tiny { get; }

        string Small { get; }

        string Large { get; }
    }
}