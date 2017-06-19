
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(719)]
    public class GameFightTurnEndMessage
    {
        public double Id { get; set; }
    }
}
