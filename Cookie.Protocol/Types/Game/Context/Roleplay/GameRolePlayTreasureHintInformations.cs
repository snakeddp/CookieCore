using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(471)]
    public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
    {
        [CustomVar]
        public ushort NpcId { get; set; }
    }
}