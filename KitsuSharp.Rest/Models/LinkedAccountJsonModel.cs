using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class LinkedAccountJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "linkedAccounts";

        [JsonProperty("disabledReason")]
        public string DisabledReason { get; set; }

        [JsonProperty("externalUserId")]
        public string ExternalUserId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("shareFrom")]
        public bool ShareFrom { get; set; }

        [JsonProperty("shareTo")]
        public bool ShareTp { get; set; }

        [JsonProperty("syncTo")]
        public bool SyncTo { get; set; }

        [JsonProperty("token")]
        public TokenJsonModel Token { get; set; }
    }
}