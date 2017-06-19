
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Chat.Channel
{
    [NetworkMessage(892)]
    public class EnabledChannelsMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] Channels { get; set; }
        [LengthType(typeof(short), true)]
        public sbyte[] Disallowed { get; set; }
    }
}
