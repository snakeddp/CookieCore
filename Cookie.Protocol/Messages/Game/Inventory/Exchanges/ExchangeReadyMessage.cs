using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5511)]
    public class ExchangeReadyMessage
    {
        [RegularBool]
        public bool Ready { get; set; }

        [CustomVar]
        public ushort Step { get; set; }
    }
}