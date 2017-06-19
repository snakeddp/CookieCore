
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5526)]
    public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        [CustomVar]
        public uint Amount { get; set; }
    }
}
