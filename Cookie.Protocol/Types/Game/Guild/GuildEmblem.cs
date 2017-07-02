using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Guild
{
    [NetworkType(87)]
    public class GuildEmblem
    {
        [CustomVar]
        public ushort SymbolShape { get; set; }

        public int SymbolColor { get; set; }
        public sbyte BackgroundShape { get; set; }
        public int BackgroundColor { get; set; }
    }
}