using KitsuSharp.Rest.Enums;

namespace KitsuSharp.Rest.Entities
{
    public interface IListImport : IKitsuEntity
    {
        string Kind { get; }

        string InputText { get; }

        ListImportStrategy Strategy { get; }

        string OriginalFile { get; }

        int Progress { get; }

        ListImportStatus Status { get; }

        int Total { get; }

        string ErrorMessage { get; }

        string ErrorTrace { get; }
    }
}