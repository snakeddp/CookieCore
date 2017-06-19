
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(177)]
    public class BasicDateMessage
    {
        public sbyte Day { get; set; }
        public sbyte Month { get; set; }
        public ushort Year { get; set; }
    }
}
