using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6217)]
    public class GameActionFightVanishMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}