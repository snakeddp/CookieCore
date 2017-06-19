using System.Linq;
using System.Text;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Parts.Usings
{
    public class Enums : IUsingPart
    {
        public void OnMatch(StringBuilder writer, ProtocolClass protocolClass)
        {
            writer.AppendLine("using Cookie.Core.Attributes.Property;");
        }

        public bool Predicat(ProtocolClass pr)
        {
            if (pr.Fields == null || !pr.Fields.Any()) return false;
            if (pr.Fields.Any(p => p.WriteMethod.StartsWith("writeVar")))
                return true;
            if (pr.Fields.Any(p => p.WriteLengthMethod.StartsWith("writeVar")) 
                && pr.Fields.Any(p => p.IsDynamicLength))
                return true;

            return pr.Fields.Any(p => p.WriteMethod.Equals("writeBoolean"))
                   && !pr.Fields.Any(p => p.UseBBW);
        }
    }
}
