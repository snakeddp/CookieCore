
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Fight.Arena
{
    [NetworkType(499)]
    public class ArenaRankInfos
    {
        [CustomVar]
        public ushort Rank { get; set; }
        [CustomVar]
        public ushort BestRank { get; set; }
        [CustomVar]
        public ushort VictoryCount { get; set; }
        [CustomVar]
        public ushort Fightcount { get; set; }
    }
}
