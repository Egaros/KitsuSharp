namespace KitsuSharp.Rest.Entities
{
    public interface ICasting : IKitsuEntity
    {
        string Role { get; }

        bool IsVoiceActor { get; }

        bool IsFeatured { get; }

        string Language { get; }
    }
}