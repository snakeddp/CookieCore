
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(715)]
    public class GameFightTurnReadyRequestMessage
    {
        public double Id { get; set; }
    }
}
