using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(30)]
    public class ServersListMessage
    {
        [CustomVar]
        public ushort AlreadyConnectedToServerId { get; set; }

        [RegularBool]
        public bool CanCreateNewCharacter { get; set; }
    }
}