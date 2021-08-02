using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupTicketMessages")]
    public class GroupTicketMessageJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}