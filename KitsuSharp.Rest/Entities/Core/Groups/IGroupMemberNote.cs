namespace KitsuSharp.Rest.Entities
{
    public interface IGroupMemberNote : IKitsuEntity
    {
        string Content { get; }

        string FormattedContent { get; }
    }
}