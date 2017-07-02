using Cookie.Protocol.Types.Game.Context.Roleplay.Fight.Arena;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6728)]
    public class GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage : GameRolePlayArenaUpdatePlayerInfosMessage
    {
        public ArenaRankInfos Team { get; set; }
        public ArenaRankInfos Duel { get; set; }
    }
}