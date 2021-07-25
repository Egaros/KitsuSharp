using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupMemberJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupMembers";

        [JsonProperty("rank")]
        public GroupMemberRank Rank { get; set; }

        [JsonProperty("unreadCount")]
        public int UnreadCount { get; set; }
    }
}