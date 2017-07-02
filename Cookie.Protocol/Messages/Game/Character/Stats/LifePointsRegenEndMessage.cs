using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(5686)]
    public class LifePointsRegenEndMessage : UpdateLifePointsMessage
    {
        [CustomVar]
        public uint LifePointsGained { get; set; }
    }
}