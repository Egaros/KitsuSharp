namespace KitsuSharp.Rest.Entities.Reactions
{
    public interface IMediaReaction : IKitsuEntity
    {
        string Reaction { get; }

        int UpVotesCount { get; }
    }
}