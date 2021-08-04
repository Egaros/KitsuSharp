using System.Collections.Generic;

namespace KitsuSharp.Rest.Entities
{
    public interface IStreamingLink : IKitsuEntity
    {
        IReadOnlyList<string> Dubs { get; }

        IReadOnlyList<string> Subs { get; }

        string Url { get; }
    }
}