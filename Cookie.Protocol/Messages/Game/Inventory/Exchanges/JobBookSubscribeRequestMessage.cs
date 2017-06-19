
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6592)]
    public class JobBookSubscribeRequestMessage
    {
        [LengthType(typeof(short), true)]
        public sbyte[] JobIds { get; set; }
    }
}
