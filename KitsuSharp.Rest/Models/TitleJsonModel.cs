using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{

    public class TitleJsonModel
    {
        [JsonProperty("en")]
        public string English { get; set; }

        [JsonProperty("en_jp")]
        public string EnglishJapanese { get; set; }

        [JsonProperty("ja_jp")]
        public string Japanese { get; set; }
    }
}