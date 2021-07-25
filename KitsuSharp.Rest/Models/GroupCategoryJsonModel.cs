using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupCategoryJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupCategories";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}