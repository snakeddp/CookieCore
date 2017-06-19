
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5512)]
    public class ExchangeStartedMessage
    {
        public byte ExchangeType { get; set; }
    }
}
