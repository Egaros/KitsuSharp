using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class StatDataJsonModel
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_media")]
        public int TotalMedia { get; set; }

        //todo
    }
}