using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("mangaStaff")]
    public class MangaStaffJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}