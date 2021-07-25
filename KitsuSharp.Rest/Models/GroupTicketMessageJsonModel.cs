using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupTicketMessageJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupTicketMessages";

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}