using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5522)]
    public class ExchangeRequestedMessage
    {
        public byte ExchangeType { get; set; }
    }
}