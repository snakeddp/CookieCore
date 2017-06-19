using System.Text;
using Cookie.ProtocolBuilder.Extensions;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Fields
{
    public class CustomType : IFieldPart
    {
        public bool Predicat(Field fi) => !fi.IsVector && (fi.UseTypeManager || string.IsNullOrEmpty(fi.WriteMethod));

        public void OnMatch(StringBuilder writer, Field fi)
        {
            writer.AppendLine($"        public {fi.Type} {fi.Name.Capitalize()} {{ get; set; }}");
        }
    }
}
