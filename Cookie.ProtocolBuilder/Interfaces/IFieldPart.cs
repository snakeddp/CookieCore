using System.Text;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Interfaces
{
    public interface IFieldPart
    {
        bool Predicat(Field fi);
        void OnMatch(StringBuilder writer, Field fi);
    }
}
