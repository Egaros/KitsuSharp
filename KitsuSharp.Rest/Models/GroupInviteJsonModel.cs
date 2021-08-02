using System;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupInvites")]
    public class GroupInviteJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("acceptedAt")]
        public DateTimeOffset? AcceptedAt { get; set; }

        [JsonProperty("declinedAt")]
        public DateTimeOffset? DeclinedAt { get; set; }

        [JsonProperty("revokedAt")]
        public DateTimeOffset? RevokedAt { get; set; }
    }
}