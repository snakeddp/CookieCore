
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6004)]
    public class ExchangeObjectUseInWorkshopMessage
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
        [CustomVar]
        public int Quantity { get; set; }
    }
}
