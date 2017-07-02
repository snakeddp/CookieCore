using System.Linq;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Helpers;

namespace Cookie.ProtocolBuilder.Json.Serializables.Protocol
{
    public class ProtocolClass
    {
        public int ProtocolId { get; set; }

        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Parent { get; set; }

        public bool UseHashFunc { get; set; }

        public Field[] Fields { get; set; }
    }

    public static class ProtocolClassExtensions
    {
        public static string NamespaceToPath(this string s)
        {
            var splited = s.Split('.').ToList();

            #region "TooLazyTo" Code Region

            // TODO : find better way to do it
            splited.Remove("com");
            splited.Remove("ankamagames");
            splited.Remove("dofus");
            splited.Remove("network");

            var converted = string.Concat(splited.Select(name => $@"{name.Capitalize()}\"));

            #endregion

            return $@"{converted}";
        }

        public static string NamespaceToCSharpFormat(this string s)
        {
            var splited = s.Split('.').ToList();

            #region "TooLazyTo" Code Region

            // TODO : find better way to do it
            splited.Remove("com");
            splited.Remove("ankamagames");
            splited.Remove("dofus");
            splited.Remove("network");

            var converted = string.Concat(splited.Select(name => $@"{name.Capitalize()}."));

            #endregion

            return converted.Remove(converted.Length - 1);
        }

        public static string TypeToCSharpFormat(this string s)
        {
            Throw.IfNull(s, nameof(s));

            switch (s)
            {
                case "uint8":
                    return "sbyte";
                case "int8":
                    return "byte";
                case "uint16":
                    return "ushort";
                case "int16":
                    return "short";
                case "uint32":
                    return "uint";
                case "int32":
                    return "int";
                case "uint64":
                    return "ulong";
                case "int64":
                    return "long";
                case "float32":
                    return "float";
                case "float64":
                    return "double";
                default:
                    return s;
            }
        }

        public static bool IsPrimitiveType(this string s)
        {
            Throw.IfNull(s, nameof(s));

            switch (s)
            {
                case "bool":
                    return true;
                case "string":
                    return true;
                case "uint8":
                    return true;
                case "int8":
                    return true;
                case "uint16":
                    return true;
                case "int16":
                    return true;
                case "uint32":
                    return true;
                case "int32":
                    return true;
                case "uint64":
                    return true;
                case "int64":
                    return true;
                case "float32":
                    return true;
                case "float64":
                    return true;
            }

            return false;
        }

        public static bool IsCustomType(this string s)
        {
            Throw.IfNull(s, nameof(s));

            switch (s)
            {
                case "uint16":
                    return true;
                case "int16":
                    return true;
                case "uint32":
                    return true;
                case "int32":
                    return true;
                case "int64":
                    return true;
            }

            return false;
        }
    }
}