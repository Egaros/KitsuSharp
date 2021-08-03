using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IAnimeCharacter : IKitsuEntity
    {
        CharacterRole Role { get; }
    }
}