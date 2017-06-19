
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6541)]
    public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
    {
        public double RequestedId { get; set; }
    }
}
