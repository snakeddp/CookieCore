using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6470)]
    public class ExchangeObjectTransfertListWithQuantityToInvMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Ids { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Qtys { get; set; }
    }
}