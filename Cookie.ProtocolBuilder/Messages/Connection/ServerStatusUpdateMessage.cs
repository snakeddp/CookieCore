using Cookie.Protocol.Types.Connection;

namespace Cookie.Protocol.Messages.Connection
{
    [NetworkMessage(50)]
    public class ServerStatusUpdateMessage
    {
        public GameServerInformations Server { get; set; }
    }
}