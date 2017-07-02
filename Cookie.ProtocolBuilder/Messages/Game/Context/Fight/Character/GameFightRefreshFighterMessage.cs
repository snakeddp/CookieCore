using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Character
{
    [NetworkMessage(6309)]
    public class GameFightRefreshFighterMessage
    {
        public GameContextActorInformations Informations { get; set; }
    }
}