
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(123)]
    public class GoldItem : Item
    {
        [CustomVar]
        public long Sum { get; set; }
    }
}
