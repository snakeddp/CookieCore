using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6587)]
    public class IdolSelectRequestMessage
    {
        [CustomVar]
        public ushort IdolId { get; set; }

        public bool Activate { get; set; }
        public bool Party { get; set; }
    }
}