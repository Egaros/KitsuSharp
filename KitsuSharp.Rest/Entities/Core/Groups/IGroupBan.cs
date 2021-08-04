namespace KitsuSharp.Rest.Entities
{
    public interface IGroupBan : IKitsuEntity
    {
        string Notes { get; }

        string FormattedNotes { get; }
    }
}