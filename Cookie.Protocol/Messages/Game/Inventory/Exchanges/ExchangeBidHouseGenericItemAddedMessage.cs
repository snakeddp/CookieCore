using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5947)]
    public class ExchangeBidHouseGenericItemAddedMessage
    {
        [CustomVar]
        public ushort ObjGenericId { get; set; }
    }
}