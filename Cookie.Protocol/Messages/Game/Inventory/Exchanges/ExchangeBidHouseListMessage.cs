
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5807)]
    public class ExchangeBidHouseListMessage
    {
        [CustomVar]
        public ushort Id { get; set; }
    }
}
