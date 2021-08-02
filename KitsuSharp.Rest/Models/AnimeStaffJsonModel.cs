using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("animeStaff")]
    public class AnimeStaffJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}