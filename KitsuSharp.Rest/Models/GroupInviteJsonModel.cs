using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupInviteJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupInvites";

        [JsonProperty("acceptedAt")]
        public DateTimeOffset? AcceptedAt { get; set; }

        [JsonProperty("declinedAt")]
        public DateTimeOffset? DeclinedAt { get; set; }

        [JsonProperty("revokedAt")]
        public DateTimeOffset? RevokedAt { get; set; }
    }
}