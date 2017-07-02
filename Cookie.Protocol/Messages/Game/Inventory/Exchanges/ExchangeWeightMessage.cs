using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5793)]
    public class ExchangeWeightMessage
    {
        [CustomVar]
        public uint CurrentWeight { get; set; }

        [CustomVar]
        public uint MaxWeight { get; set; }
    }
}