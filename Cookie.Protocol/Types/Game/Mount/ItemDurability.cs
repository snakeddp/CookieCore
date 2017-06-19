
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Mount
{
    [NetworkType(168)]
    public class ItemDurability
    {
        public short Durability { get; set; }
        public short DurabilityMax { get; set; }
    }
}
