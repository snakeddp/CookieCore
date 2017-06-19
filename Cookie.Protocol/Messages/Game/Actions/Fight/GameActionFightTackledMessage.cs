
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(1004)]
    public class GameActionFightTackledMessage : AbstractGameActionMessage
    {
        [LengthType(typeof(short), true)]
        public double[] TacklersIds { get; set; }
    }
}
