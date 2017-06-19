using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields.Arrays
{
    public class TypeArrayWithCustomLength : IFieldPart
    {
        public bool Predicat(Field fi) =>
            fi.IsVector
            && fi.UseTypeManager
            && fi.WriteLengthMethod.StartsWith("writeVar")
            && !fi.UseTypeManager;

        public void OnMatch(StringBuilder writer, Field fi)
        {
            writer.AppendLine($"        [LengthType(typeof({fi.WriteLengthMethod.GetLengthType()}), true)]");
            writer.AppendLine($"        public {fi.Type.TypeToCSharpFormat()}[] {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}
