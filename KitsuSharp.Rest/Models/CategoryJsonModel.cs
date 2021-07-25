using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CategoryJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "categories";

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public ImageJsonModel Image { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalMediaCount")]
        public int TotalMediaCount { get; set; }
    }
}