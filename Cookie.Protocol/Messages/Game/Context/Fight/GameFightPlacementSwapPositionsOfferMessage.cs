
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6542)]
    public class GameFightPlacementSwapPositionsOfferMessage
    {
        public uint RequestId { get; set; }
        public double RequesterId { get; set; }
        [CustomVar]
        public ushort RequesterCellId { get; set; }
        public double RequestedId { get; set; }
        [CustomVar]
        public ushort RequestedCellId { get; set; }
    }
}
