using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class MangaStaffJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "mangaStaff";

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}