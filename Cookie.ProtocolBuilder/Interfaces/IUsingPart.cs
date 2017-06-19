using System.Text;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Interfaces
{
    public interface IUsingPart
    {
        bool Predicat(ProtocolClass pr);
        void OnMatch(StringBuilder writer, ProtocolClass protocolClass);
    }
}
