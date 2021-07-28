using System.Collections.Generic;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class TokenJsonModel
    {
        [JsonProperty("application")]
        public ApplicationJsonModel Application { get; set; }

        [JsonProperty("created_at")]
        public ulong CreatedAt { get; set; }

        [JsonProperty("expires_in_seconds")]
        public ulong ExpiresInSeconds { get; set; }

        [JsonProperty("resource_owner_id")]
        public int ResourceOwnerId { get; set; }

        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; } = new List<string>();
    }

    public class ApplicationJsonModel
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}