using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class GroupPermissionJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "groupPermissions";

        [JsonProperty("permission")]
        public GroupPermission Permission { get; set; }
    }
}