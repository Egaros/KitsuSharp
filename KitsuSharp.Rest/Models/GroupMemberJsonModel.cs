using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupMembers")]
    public class GroupMemberJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("rank")]
        public GroupMemberRank Rank { get; set; }

        [JsonProperty("unreadCount")]
        public int UnreadCount { get; set; }
    }
}