namespace KitsuSharp.Rest.Entities
{
    public interface ITitleEntity
    {
        ITitles Titles { get; }
    }

    public interface ITitles
    {
        string English { get; }

        string EnglishJapanese { get; }

        string Japanese { get; }
    }
}