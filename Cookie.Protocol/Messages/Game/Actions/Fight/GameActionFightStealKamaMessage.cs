
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5535)]
    public class GameActionFightStealKamaMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        [CustomVar]
        public long Amount { get; set; }
    }
}
