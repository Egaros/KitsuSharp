using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class AnimeStaffJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "animeStaff";

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}