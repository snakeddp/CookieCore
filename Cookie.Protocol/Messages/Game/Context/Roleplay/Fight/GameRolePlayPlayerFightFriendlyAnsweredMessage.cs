using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(5733)]
    public class GameRolePlayPlayerFightFriendlyAnsweredMessage
    {
        public int FightId { get; set; }

        [CustomVar]
        public long SourceId { get; set; }

        [CustomVar]
        public long TargetId { get; set; }

        [RegularBool]
        public bool Accept { get; set; }
    }
}