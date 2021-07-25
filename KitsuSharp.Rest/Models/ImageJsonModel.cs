using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ImageJsonModel
    {
        [JsonProperty("tiny")]
        public string Tiny;

        [JsonProperty("small")]
        public string Small;

        [JsonProperty("medium")]
        public string Medium;

        [JsonProperty("large")]
        public string Large;

        [JsonProperty("original")]
        public string Original;
    }
}