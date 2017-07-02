using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Authorized
{
    [NetworkMessage(6127)]
    public class ConsoleCommandsListMessage
    {
        [LengthType(typeof(short), true)]
        public string[] Aliases { get; set; }

        [LengthType(typeof(short), true)]
        public string[] Args { get; set; }

        [LengthType(typeof(short), true)]
        public string[] Descriptions { get; set; }
    }
}