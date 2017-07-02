using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(5684)]
    public class LifePointsRegenBeginMessage
    {
        public sbyte RegenRate { get; set; }
    }
}