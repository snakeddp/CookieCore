using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(6469)]
    public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] ServerIds { get; set; }
    }
}