using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IGroupMember : IKitsuEntity
    {
        GroupMemberRank Rank { get; }

        int UnreadCount { get; }
    }
}