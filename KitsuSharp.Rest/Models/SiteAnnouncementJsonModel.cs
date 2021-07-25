using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class SiteAnnouncementJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "siteAnnouncements";

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}