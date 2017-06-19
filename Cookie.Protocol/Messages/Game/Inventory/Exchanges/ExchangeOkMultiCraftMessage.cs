
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5768)]
    public class ExchangeOkMultiCraftMessage
    {
        [CustomVar]
        public long InitiatorId { get; set; }
        [CustomVar]
        public long OtherId { get; set; }
        public byte Role { get; set; }
    }
}
