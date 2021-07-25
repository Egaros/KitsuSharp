using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupTicketMessageJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("content")]
        public string Content;
    }
}