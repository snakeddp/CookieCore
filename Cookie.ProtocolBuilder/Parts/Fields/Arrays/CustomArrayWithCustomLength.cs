using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields.Arrays
{
    public class CustomArrayWithCustomLength
    {
        public bool Predicat(Field fi)
        {
            return fi.IsVector
                   && fi.Type.IsCustomType()
                   && fi.WriteMethod.Contains("Var")
                   && fi.WriteLengthMethod.Contains("Var")
                   && !fi.UseTypeManager;
        }

        public void OnMatch(StringBuilder writer, Field fi)
        {
            writer.AppendLine("        [CustomVar]");
            writer.AppendLine($"        [LengthType(typeof({fi.WriteLengthMethod.GetLengthType()}), true)]");
            writer.AppendLine(
                $"        public {fi.Type.TypeToCSharpFormat()}[] {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}