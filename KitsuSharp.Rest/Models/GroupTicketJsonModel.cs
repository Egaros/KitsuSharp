using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupTicketJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupTickets";

        [JsonProperty("status")]
        public GroupTicketStatus Status { get; set; }
    }
}