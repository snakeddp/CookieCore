using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(252)]
    public class GameContextRemoveMultipleElementsMessage
    {
        [LengthType(typeof(short), true)]
        public double[] ElementsIds { get; set; }
    }
}