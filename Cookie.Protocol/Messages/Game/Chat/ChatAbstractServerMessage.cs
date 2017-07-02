using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat
{
    [NetworkMessage(880)]
    public class ChatAbstractServerMessage
    {
        public sbyte Channel { get; set; }
        public string Content { get; set; }
        public uint Timestamp { get; set; }
        public string Fingerprint { get; set; }
    }
}