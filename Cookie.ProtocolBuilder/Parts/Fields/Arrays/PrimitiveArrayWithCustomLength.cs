using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields.Arrays
{
    public class PrimitiveArrayWithCustomLength : IFieldPart
    {
        public bool Predicat(Field fi)
        {
            return fi.IsVector
                   && fi.Type.IsPrimitiveType()
                   && !fi.WriteMethod.Contains("Var")
                   && fi.IsDynamicLength
                   && !fi.UseTypeManager;
        }

        public void OnMatch(StringBuilder writer, Field fi)
        {
            writer.AppendLine($"        [LengthType(typeof({fi.WriteLengthMethod.GetLengthType()}), true)]");
            writer.AppendLine(
                $"        public {fi.Type.TypeToCSharpFormat()}[] {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}