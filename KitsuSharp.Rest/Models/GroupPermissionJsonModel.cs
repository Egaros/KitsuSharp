using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupPermissions")]
    public class GroupPermissionJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("permission")]
        public GroupPermission Permission { get; set; }
    }
}