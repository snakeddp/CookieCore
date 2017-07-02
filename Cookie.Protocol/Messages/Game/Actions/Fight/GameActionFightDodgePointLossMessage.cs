using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5828)]
    public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public ushort Amount { get; set; }
    }
}