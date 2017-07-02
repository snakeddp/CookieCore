using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields
{
    public class CustomVar : IFieldPart
    {
        public bool Predicat(Field fi)
        {
            return !fi.IsVector && fi.WriteMethod.StartsWith("writeVar") && !fi.UseTypeManager &&
                   fi.Type.IsCustomType();
        }

        public void OnMatch(StringBuilder writer, Field fi)
        {
            writer.AppendLine("        [CustomVar]");
            writer.AppendLine($"        public {fi.Type.TypeToCSharpFormat()} {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}