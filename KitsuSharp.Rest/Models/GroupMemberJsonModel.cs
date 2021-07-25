using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupMemberJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("rank")]
        public GroupMemberRank Rank;

        [JsonProperty("unreadCount")]
        public int UnreadCount;
    }
}