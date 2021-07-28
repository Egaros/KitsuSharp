using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class PeopleJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "people";

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("malId")]
        public int MalId { get; set; }
    }
}