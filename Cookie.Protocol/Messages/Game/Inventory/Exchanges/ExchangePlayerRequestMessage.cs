using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5773)]
    public class ExchangePlayerRequestMessage : ExchangeRequestMessage
    {
        [CustomVar]
        public long Target { get; set; }
    }
}