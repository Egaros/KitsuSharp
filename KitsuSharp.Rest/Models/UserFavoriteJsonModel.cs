using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("favorites")]
    public class UserFavoriteJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("favRank")]
        public int FavRank { get; set; }
    }
}