using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Messages.Connection;
using Cookie.Protocol.Messages.Handshake;
using Cookie.Sockets;

namespace Cookie.Handlers.Connection
{
    public static class ConnectionHandler
    {
        [NetworkMessageHandler(typeof(ProtocolRequired))]
        public static void OnProtocolRequired(DofusSocket client, ProtocolRequired message)
        {
            client.Write($"Youhou ! {message.CurrentVersion} / {message.RequiredVersion}");
        }

        //[NetworkMessageHandler(typeof(HelloConnectMessage))]
        //public static void OnHelloConnectMessage(DofusSocket client, HelloConnectMessage message)
        //{
        //    //
        //}
    }
}