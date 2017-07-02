using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields
{
    public class Primitive : IFieldPart
    {
        public bool Predicat(Field fi)
        {
            return !fi.IsVector
                   && fi.Type.IsPrimitiveType()
                   && !fi.WriteMethod.Contains("Var")
                   && !fi.UseTypeManager
                   && !string.IsNullOrEmpty(fi.WriteMethod);
        }


        public void OnMatch(StringBuilder writer, Field fi)
        {
            if (fi.Type == "bool" && fi.WriteMethod.StartsWith("writeBool") && !fi.UseBBW)
                writer.AppendLine("        [RegularBool]");
            writer.AppendLine($"        public {fi.Type.TypeToCSharpFormat()} {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}