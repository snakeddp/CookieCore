
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6307)]
    public class GameFightTurnResumeMessage : GameFightTurnStartMessage
    {
        [CustomVar]
        public uint RemainingTime { get; set; }
    }
}
