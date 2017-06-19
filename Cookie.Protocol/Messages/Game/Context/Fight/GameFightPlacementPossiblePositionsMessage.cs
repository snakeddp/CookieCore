
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(703)]
    public class GameFightPlacementPossiblePositionsMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PositionsForChallengers { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PositionsForDefenders { get; set; }
        public sbyte TeamNumber { get; set; }
    }
}
