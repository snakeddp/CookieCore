
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(701)]
    public class GameFightJoinRequestMessage
    {
        public double FighterId { get; set; }
        public int FightId { get; set; }
    }
}
