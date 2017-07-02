using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(158)]
    public class GameFightFighterNamedInformations : GameFightFighterInformations
    {
        public string Name { get; set; }
        public PlayerStatus Status { get; set; }
    }
}