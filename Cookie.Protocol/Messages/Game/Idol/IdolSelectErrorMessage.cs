using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6584)]
    public class IdolSelectErrorMessage
    {
        public sbyte Reason { get; set; }

        [CustomVar]
        public ushort IdolId { get; set; }

        public bool Activate { get; set; }
        public bool Party { get; set; }
    }
}