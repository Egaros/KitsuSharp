using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("categories")]
    public class CategoryJsonModel : ResourceBaseJsonModel
    {
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