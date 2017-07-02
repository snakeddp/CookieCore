using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6546)]
    public class GameFightPlacementSwapPositionsCancelledMessage
    {
        public uint RequestId { get; set; }
        public double CancellerId { get; set; }
    }
}