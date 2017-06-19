
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(42)]
    public class SelectedServerDataMessage
    {
        [CustomVar]
        public ushort ServerId { get; set; }
        public string Address { get; set; }
        public ushort Port { get; set; }
        [RegularBool]
        public bool CanCreateNewCharacter { get; set; }
        [LengthType(typeof(int), true)]
        public byte[] Ticket { get; set; }
    }
}
