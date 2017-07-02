using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(494)]
    public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
    {
        [CustomVar]
        public long Price { get; set; }
    }
}