using System;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupInviteJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("acceptedAt")]
        public DateTimeOffset? AcceptedAt;

        [JsonProperty("declinedAt")]
        public DateTimeOffset? DeclinedAt;

        [JsonProperty("revokedAt")]
        public DateTimeOffset? RevokedAt;
    }
}