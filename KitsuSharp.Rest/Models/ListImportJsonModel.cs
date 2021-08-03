using JsonApiSerializer;
using KitsuSharp.Rest.Enums;
using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    [ResourceType("listImports")]
    public class ListImportJsonModel : ResourceBaseJsonModel
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("inputText")]
        public string InputText { get; set; }

        [JsonProperty("strategy")]
        public ListImportStrategy Strategy { get; set; }

        [JsonProperty("inputFile")]
        public InputFileJsonModel InputFile { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("status")]
        public ListImportStatus Status { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorTrace")]
        public string ErrorTrace { get; set; }
    }

    public class InputFileJsonModel
    {
        [JsonProperty("original")]
        public string Original { get; set; }
    }
}