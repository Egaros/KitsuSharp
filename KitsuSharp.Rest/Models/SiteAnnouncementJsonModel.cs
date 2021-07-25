using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class SiteAnnouncementJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("title")]
        public string Title;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("imageUrl")]
        public string ImageUrl;

        [JsonProperty("link")]
        public string Link;
    }
}