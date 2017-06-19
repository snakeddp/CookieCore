
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(473)]
    public class TreasureHuntFlag
    {
        public int MapId { get; set; }
        public sbyte State { get; set; }
    }
}
