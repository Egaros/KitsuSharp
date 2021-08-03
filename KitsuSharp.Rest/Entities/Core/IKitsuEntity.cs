using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IKitsuEntity
    {
        DateTimeOffset CreatedAt { get; set; }

        DateTimeOffset UpdatedAt { get; set; }
    }
}