using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(5732)]
    public class GameRolePlayPlayerFightFriendlyAnswerMessage
    {
        public int FightId { get; set; }

        [RegularBool]
        public bool Accept { get; set; }
    }
}