
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(700)]
    public class GameFightStartingMessage
    {
        public sbyte FightType { get; set; }
        public double AttackerId { get; set; }
        public double DefenderId { get; set; }
    }
}
