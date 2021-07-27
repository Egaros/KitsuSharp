using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    // Still in development API side.
    public class StatJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "stats";

        [JsonProperty("kind")]
        public StatKind Kind { get; set; }


    }
}