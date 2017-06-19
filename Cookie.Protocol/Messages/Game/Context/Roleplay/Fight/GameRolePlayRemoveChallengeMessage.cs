
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(300)]
    public class GameRolePlayRemoveChallengeMessage
    {
        public int FightId { get; set; }
    }
}
