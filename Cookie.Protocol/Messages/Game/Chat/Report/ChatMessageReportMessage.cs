
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Chat.Report
{
    [NetworkMessage(821)]
    public class ChatMessageReportMessage
    {
        public string SenderName { get; set; }
        public string Content { get; set; }
        public uint Timestamp { get; set; }
        public sbyte Channel { get; set; }
        public string Fingerprint { get; set; }
        public sbyte Reason { get; set; }
    }
}
