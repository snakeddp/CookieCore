
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6279)]
    public class GameRolePlayArenaFightAnswerMessage
    {
        public int FightId { get; set; }
        [RegularBool]
        public bool Accept { get; set; }
    }
}
