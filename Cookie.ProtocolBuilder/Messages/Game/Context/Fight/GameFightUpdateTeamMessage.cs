using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(5572)]
    public class GameFightUpdateTeamMessage
    {
        public ushort FightId { get; set; }
        public FightTeamInformations Team { get; set; }
    }
}