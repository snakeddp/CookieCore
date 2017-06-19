
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5505)]
    public class ExchangeRequestMessage
    {
        public byte ExchangeType { get; set; }
    }
}
