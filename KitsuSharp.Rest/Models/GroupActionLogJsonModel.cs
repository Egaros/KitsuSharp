using JsonApiSerializer;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("groupActionLogs")]
    public class GroupActionLogJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("verb")]
        public string Verb { get; set; }
    }
}