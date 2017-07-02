using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6304)]
    public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short Delta { get; set; }
    }
}