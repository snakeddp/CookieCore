using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Core.Enums;
using Cookie.Protocol.Types.Connection;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(30, Origin.Server)]
    public class ServerListMessage
    {
        public GameServerInformations[] Servers { get; set; }

        [CustomVar]
        public short AlreadyConnectedToServerId { get; set; }

        [RegularBool]
        public bool CanCreateNewCharacter { get; set; }
    }
}