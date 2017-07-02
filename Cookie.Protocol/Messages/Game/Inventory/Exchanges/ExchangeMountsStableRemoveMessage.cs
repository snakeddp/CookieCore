using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6556)]
    public class ExchangeMountsStableRemoveMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] MountsId { get; set; }
    }
}