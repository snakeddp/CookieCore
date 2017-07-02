using System.IO;
using System.Linq;
using System.Text;
using Cookie.ProtocolBuilder.Json;
using Cookie.ProtocolBuilder.Json.Serializables.Enum;

namespace Cookie.ProtocolBuilder.Writers
{
    public class EnumClassWriter
    {
        private readonly StringBuilder _writer;

        public EnumClassWriter(EnumClass eClass, D2JsonProvider provider)
        {
            Class = eClass;
            Provider = provider;

            _writer = new StringBuilder();
        }

        public EnumClass Class { get; }
        public D2JsonProvider Provider { get; }
        public string ClassContent => _writer.ToString();
        public string ClassPath => $@"{Directory.GetCurrentDirectory()}\Enums\{Class.Name}.cs";
        public string ClassDirectory => $@"{Directory.GetCurrentDirectory()}\Enums\";

        public bool TryCreateRepositories()
        {
            if (!Directory.Exists(ClassDirectory))
                Directory.CreateDirectory(ClassDirectory);

            return Directory.Exists(ClassDirectory);
        }

        public bool TryCreateFile()
        {
            if (!File.Exists(ClassPath))
                File.CreateText(ClassPath);

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
            _writer.AppendLine("using System;");
        }

        public void WriteNamespace()
        {
            _writer.AppendLine();
            _writer.AppendLine("namespace Cookie.Protocol.Enums");
            _writer.AppendLine("{");
        }

        public void WriteClass()
        {
            _writer.AppendLine("    [Flags]");
            _writer.AppendLine($"    public enum {Class.Name}");
            _writer.AppendLine("    {");
        }

        public void WriteProperties()
        {
            if (Class.Values == null || !Class.Values.Any())
            {
                EndClass();
                return;
            }

            foreach (var v in Class.Values)
                _writer.AppendLine(
                    Class.Values.Last().Equals(v)
                        ? $"        {v.Name} = {v.Value}"
                        : $"        {v.Name} = {v.Value},");

            EndClass();
        }

        private void EndClass()
        {
            _writer.AppendLine("    }");
            _writer.AppendLine("}");
        }
    }
}