using System;

namespace KitsuSharp.Rest.Entities
{
    public interface IKitsuEntity
    {
        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}