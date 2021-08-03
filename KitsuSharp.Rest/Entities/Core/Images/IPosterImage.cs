namespace KitsuSharp.Rest.Entities
{
    public interface IPosterImage : IImageEntity
    {
        string Tiny { get; }

        string Small { get; }

        string Medium { get; }

        string Large { get; }
    }
}