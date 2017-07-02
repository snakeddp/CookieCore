using System.IO;
using System.Linq;
using System.Text;
using Cookie.ProtocolBuilder.Interfaces;
using Cookie.ProtocolBuilder.Json;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;
using Cookie.ProtocolBuilder.Managers;
using Cookie.ProtocolBuilder.Parts.Usings;

namespace Cookie.ProtocolBuilder.Writers
{
    public class MessageClassWriter : IClassWriter
    {
        private readonly StringBuilder _writer;

        static MessageClassWriter()
        {
            PartsManager<IUsingPart>.GetParts();
            PartsManager<IFieldPart>.GetParts();
        }

        public MessageClassWriter(ProtocolClass pClass, D2JsonProvider provider)
        {
            Class = pClass;
            Provider = provider;

            _writer = new StringBuilder();
        }

        public D2JsonProvider Provider { get; }
        public ProtocolClass Class { get; }
        public string ClassContent => _writer.ToString();

        public string ClassPath =>
            $@"{Directory.GetCurrentDirectory()}\{Class.Namespace.NamespaceToPath()}{Class.Name}.cs";

        public bool TryCreateRepositories()
        {
            var path = Class.Namespace.NamespaceToPath();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return Directory.Exists(path);
        }

        public bool TryCreateFile()
        {
            if (!File.Exists(ClassPath))
                File.Create(ClassPath);

            return File.Exists(ClassPath);
        }

        public void WriteFile()
        {
            WriteUsingDirectives();
            WriteNamespace();
            WriteClass();
            WriteProperties();

            if (string.IsNullOrEmpty(ClassContent) || !File.Exists(ClassPath)) return;

            File.WriteAllText(ClassPath, ClassContent, Encoding.UTF8);
        }

        public void WriteUsingDirectives()
        {
            _writer.AppendLine("");
            _writer.AppendLine("using Cookie.Core.Attributes.Class;");

            foreach (var part in PartsManager<IUsingPart>.Parts)
            {
                var predicat = part.Predicat(Class);

                if (!predicat) continue;
                part.OnMatch(_writer, Class);
                break;
            }

            if (Class.Fields == null || !Class.Fields.Any())
                return;

            foreach (var f in Class.Fields)
            {
                var typePart = new Types();
                if (typePart.Predicat(f))
                    typePart.OnMatch(_writer, f, Provider);
            }
        }

        public void WriteNamespace()
        {
            _writer.AppendLine();
            _writer.AppendLine($"namespace Cookie.Protocol.{Class.Namespace.NamespaceToCSharpFormat()}");
            _writer.AppendLine("{");
        }

        public void WriteClass()
        {
            _writer.AppendLine($"    [NetworkMessage({Class.ProtocolId})]");

            _writer.AppendLine(string.IsNullOrEmpty(Class.Parent)
                ? $"    public class {Class.Name}"
                : $"    public class {Class.Name} : {Class.Parent}");

            _writer.AppendLine("    {");
        }

        public void WriteProperties()
        {
            if (Class.Fields == null || !Class.Fields.Any())
            {
                EndClass();
                return;
            }

            foreach (var f in Class.Fields)
            foreach (var part in PartsManager<IFieldPart>.Parts)
            {
                var predicat = part.Predicat(f);

                if (!predicat) continue;
                part.OnMatch(_writer, f);
                break;
            }

            EndClass();
        }

        private void EndClass()
        {
            _writer.AppendLine("    }");
            _writer.AppendLine("}");
        }
    }
}