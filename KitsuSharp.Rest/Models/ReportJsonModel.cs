using System;
using KitsuSharp.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class ReportJsonModel
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt;

        [JsonProperty("reason")]
        public ReportReason Reason;

        [JsonProperty("status")]
        public ReportStatus Status;

        [JsonProperty("explanation")]
        public string Explanation;

        [JsonProperty("naughtyType")]
        public string NaughtyType;

        [JsonProperty("naughtyId")]
        public int NaughtyId;
    }
}