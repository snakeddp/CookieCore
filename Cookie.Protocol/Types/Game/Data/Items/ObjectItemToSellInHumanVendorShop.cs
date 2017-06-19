
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items.Effects;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(359)]
    public class ObjectItemToSellInHumanVendorShop : Item
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }
        [CustomVar]
        public uint ObjectUID { get; set; }
        [CustomVar]
        public uint Quantity { get; set; }
        [CustomVar]
        public long ObjectPrice { get; set; }
        [CustomVar]
        public long PublicPrice { get; set; }
    }
}
