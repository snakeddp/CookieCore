using System.Collections.Immutable;
using System.IO;
using Cookie.ProtocolBuilder.Helpers;
using Cookie.ProtocolBuilder.Json.Serializables.Enum;
using Cookie.ProtocolBuilder.Json.Serializables.Protocol;
using Newtonsoft.Json.Linq;
using static System.Console;

namespace Cookie.ProtocolBuilder.Json
{
    public class D2JsonProvider
    {
        /// <summary>
        ///     Simple json reader which read d2json output file
        /// </summary>
        /// <param name="protocolJsonPath">The path of the .json file</param>
        /// <returns>
        ///     <see cref="D2JsonProvider" /> object containing three <see cref="ImmutableList{T}" /> of different type of
        ///     dofus classes
        /// </returns>
        public D2JsonProvider(string protocolJsonPath)
        {
            Throw.IfNull(protocolJsonPath, nameof(protocolJsonPath));

            ProtocolJsonPath = protocolJsonPath;
            JsonFullString = File.ReadAllText(ProtocolJsonPath);
            Protocol = JObject.Parse(JsonFullString);

            Messages = Protocol.GetValue("Messages").ToObject<ProtocolClass[]>().ToImmutableList();
            Types = Protocol.GetValue("Types").ToObject<ProtocolClass[]>().ToImmutableList();
            Enums = Protocol.GetValue("Enums").ToObject<EnumClass[]>().ToImmutableList();

            WriteLine($"> {Messages.Count} messages, {Types.Count} types and {Enums.Count} enums found");
        }

        private string JsonFullString { get; }
        private JObject Protocol { get; }

        public string ProtocolJsonPath { get; }
        public ImmutableList<ProtocolClass> Messages { get; }
        public ImmutableList<ProtocolClass> Types { get; }
        public ImmutableList<EnumClass> Enums { get; }
    }
}