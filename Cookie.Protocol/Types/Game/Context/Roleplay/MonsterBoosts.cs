
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(497)]
    public class MonsterBoosts
    {
        [CustomVar]
        public uint Id { get; set; }
        [CustomVar]
        public ushort XpBoost { get; set; }
        [CustomVar]
        public ushort DropBoost { get; set; }
    }
}
