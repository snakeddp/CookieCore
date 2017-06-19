
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5571)]
    public class GameActionFightKillMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}
