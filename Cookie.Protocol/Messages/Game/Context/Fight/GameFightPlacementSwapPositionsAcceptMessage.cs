
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6547)]
    public class GameFightPlacementSwapPositionsAcceptMessage
    {
        public uint RequestId { get; set; }
    }
}
