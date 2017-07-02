using Cookie.ProtocolBuilder.Json.Serializables.Protocol;

namespace Cookie.ProtocolBuilder.Interfaces
{
    public interface IClassWriter
    {
        ProtocolClass Class { get; }
        string ClassContent { get; }
        string ClassPath { get; }

        bool TryCreateRepositories();
        bool TryCreateFile();
        void WriteFile();
    }
}