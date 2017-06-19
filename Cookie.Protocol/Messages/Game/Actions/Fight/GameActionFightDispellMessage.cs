
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5533)]
    public class GameActionFightDispellMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}
