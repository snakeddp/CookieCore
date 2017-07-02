using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Security
{
    [NetworkMessage(6156)]
    public class CheckFileMessage
    {
        public string FilenameHash { get; set; }
        public sbyte Type { get; set; }
        public string Value { get; set; }
    }
}