using System.Linq;
using System.Text;
using Cookie.ProtocolBuilder.Json;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Usings
{
    public class Types
    {
        public bool Predicat(Field fi) => !fi.Type.IsPrimitiveType() && (fi.UseTypeManager || string.IsNullOrEmpty(fi.WriteMethod));

        public void OnMatch(StringBuilder writer, Field fi, D2JsonProvider provider)
        {
            writer.AppendLine($"using Cookie.Protocol.{provider.Types.First(t => t.Name == fi.Type).Namespace.NamespaceToCSharpFormat()};");
        }

        public bool Predicat(ProtocolClass pr)
        {
            if (pr.Fields == null || !pr.Fields.Any()) return false;

            return pr.Fields.Any(p => p.UseTypeManager);
        }
    }
}
