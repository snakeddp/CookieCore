using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6037)]
    public class ExchangeShopStockMultiMovementRemovedMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] ObjectIdList { get; set; }
    }
}