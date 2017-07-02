using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Character
{
    [NetworkMessage(5864)]
    public class GameFightShowFighterMessage
    {
        public GameFightFighterInformations Informations { get; set; }
    }
}