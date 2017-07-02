using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(369)]
    public class Shortcut
    {
        public sbyte Slot { get; set; }
    }
}