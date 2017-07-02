using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory
{
    [NetworkMessage(6335)]
    public class ObjectAveragePricesMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Ids { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public long[] AvgPrices { get; set; }
    }
}