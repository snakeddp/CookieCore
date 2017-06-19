
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items.Effects;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(122)]
    public class BidExchangerObjectInfo
    {
        [CustomVar]
        public uint ObjectUID { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] Prices { get; set; }
    }
}
