using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IMangaCharacter : IKitsuEntity
    {
        CharacterRole Role { get; }
    }
}