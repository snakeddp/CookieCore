// ReSharper disable InconsistentNaming

using Cookie.ProtocolBuilder.Helpers;

namespace Cookie.ProtocolBuilder.Json.Serializables.Protocol
{
    public class Field
    {
        public int Length { get; set; }
        public int BBWPosition { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string WriteMethod { get; set; }
        public string WriteLengthMethod { get; set; }
        public string Method { get; set; }

        public bool IsVector { get; set; }
        public bool IsDynamicLength { get; set; }
        public bool UseTypeManager { get; set; }
        public bool UseBBW { get; set; }
    }

    public static class FieldExtensions
    {
        public static string GetLengthType(this string s)
        {
            Throw.IfNull(s, nameof(s));

            if (s.StartsWith("write") && !s.StartsWith("writeVar"))
                return s.Replace("write", string.Empty).ToLower();
            if (s.StartsWith("writeVar"))
                return s.Replace("writeVar", string.Empty).ToLower();

            return string.Empty;
        }
    }
}