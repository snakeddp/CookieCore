
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5532)]
    public class GameActionFightChangeLookMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public EntityLook EntityLook { get; set; }
    }
}
