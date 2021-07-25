using System.Runtime.Serialization;

namespace KitsuSharp.Rest.Enums
{
    public enum ProducerRole
    {
        [EnumMember(Value = "licensor")]
        Licensor,

        [EnumMember(Value = "producer")]
        Producer,

        [EnumMember(Value = "studio")]
        Studio
    }
}