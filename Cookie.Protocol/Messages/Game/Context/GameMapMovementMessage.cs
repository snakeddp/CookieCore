using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(951)]
    public class GameMapMovementMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] KeyMovements { get; set; }
        public short ForcedDirection { get; set; }
        public double ActorId { get; set; }
    }
}
