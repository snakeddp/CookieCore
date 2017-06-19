
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(175)]
    public class BasicTimeMessage
    {
        public double Timestamp { get; set; }
        public short TimezoneOffset { get; set; }
    }
}
