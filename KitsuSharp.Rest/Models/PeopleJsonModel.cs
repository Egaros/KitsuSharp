using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("people")]
    public class PeopleJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("malId")]
        public int MalId { get; set; }
    }
}