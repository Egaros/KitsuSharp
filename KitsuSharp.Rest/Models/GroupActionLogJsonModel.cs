using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupActionLogJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupActionLogs";

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }
}