
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(76)]
    public class ObjectEffect
    {
        [CustomVar]
        public ushort ActionId { get; set; }
    }
}
