using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ReportJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "reports";

        [JsonProperty("reason")]
        public ReportReason Reason { get; set; }

        [JsonProperty("status")]
        public ReportStatus Status { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("naughtyType")]
        public string NaughtyType { get; set; }

        [JsonProperty("naughtyId")]
        public int NaughtyId { get; set; }
    }
}