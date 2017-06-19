
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items.Effects;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5949)]
    public class ExchangeBidHouseInListAddedMessage
    {
        public int ItemUID { get; set; }
        public int ObjGenericId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] Prices { get; set; }
    }
}
