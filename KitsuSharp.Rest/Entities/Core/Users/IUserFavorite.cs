namespace KitsuSharp.Rest.Entities
{
    public interface IUserFavorite : IKitsuEntity
    {
        int FavoriteRank { get; }
    }
}