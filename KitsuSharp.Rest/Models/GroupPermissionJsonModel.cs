using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupPermissionJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("permission")]
        public GroupPermission Permission;
    }
}