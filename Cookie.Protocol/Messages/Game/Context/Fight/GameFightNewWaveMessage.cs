
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6490)]
    public class GameFightNewWaveMessage
    {
        public sbyte Id { get; set; }
        public sbyte TeamId { get; set; }
        public short NbTurnBeforeNextWave { get; set; }
    }
}
