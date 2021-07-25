using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ProducerJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "producers";

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}