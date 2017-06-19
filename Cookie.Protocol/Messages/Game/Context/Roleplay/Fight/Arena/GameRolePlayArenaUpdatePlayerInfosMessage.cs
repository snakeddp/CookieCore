
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay.Fight.Arena;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6301)]
    public class GameRolePlayArenaUpdatePlayerInfosMessage
    {
        public ArenaRankInfos Solo { get; set; }
    }
}
