
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Actions.Sequence
{
    [NetworkMessage(956)]
    public class SequenceEndMessage
    {
        [CustomVar]
        public ushort ActionId { get; set; }
        public double AuthorId { get; set; }
        public byte SequenceType { get; set; }
    }
}
