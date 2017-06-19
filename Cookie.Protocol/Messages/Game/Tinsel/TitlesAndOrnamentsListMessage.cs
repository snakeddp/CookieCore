
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6367)]
    public class TitlesAndOrnamentsListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Titles { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Ornaments { get; set; }
        [CustomVar]
        public ushort ActiveTitle { get; set; }
        [CustomVar]
        public ushort ActiveOrnament { get; set; }
    }
}
