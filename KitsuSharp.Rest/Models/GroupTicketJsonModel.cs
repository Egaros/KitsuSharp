using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupTickets")]
    public class GroupTicketJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("status")]
        public GroupTicketStatus Status { get; set; }
    }
}