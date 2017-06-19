
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(467)]
    public class GameRolePlayPortalInformations : GameRolePlayActorInformations
    {
        public PortalInformation Portal { get; set; }
    }
}
