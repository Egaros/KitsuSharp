using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class UserFavoriteJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "favorites";

        [JsonProperty("favRank")]
        public int FavRank { get; set; }
    }
}