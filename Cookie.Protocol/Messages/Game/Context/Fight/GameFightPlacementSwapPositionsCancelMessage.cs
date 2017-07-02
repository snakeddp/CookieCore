using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6543)]
    public class GameFightPlacementSwapPositionsCancelMessage
    {
        public uint RequestId { get; set; }
    }
}