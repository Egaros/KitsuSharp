using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupTicketJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("status")]
        public GroupTicketStatus Status;
    }
}