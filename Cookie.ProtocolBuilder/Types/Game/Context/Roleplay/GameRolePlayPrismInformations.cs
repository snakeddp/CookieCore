using Cookie.Protocol.Types.Game.Prism;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(161)]
    public class GameRolePlayPrismInformations : GameRolePlayActorInformations
    {
        public PrismInformation Prism { get; set; }
    }
}