using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(6073)]
    public class GameRolePlayAggressionMessage
    {
        [CustomVar]
        public long AttackerId { get; set; }

        [CustomVar]
        public long DefenderId { get; set; }
    }
}