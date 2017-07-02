using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6682)]
    public class DareWonListMessage
    {
        [LengthType(typeof(short), true)]
        public double[] DareId { get; set; }
    }
}