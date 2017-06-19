using Cookie.Core.Attributes.Class;
using Cookie.Cryptography;
using Cookie.Protocol.Enums;
using Cookie.Protocol.Messages.Connection;
using Cookie.Protocol.Messages.Handshake;
using Cookie.Protocol.Types.Version;
using Cookie.Sockets;

namespace Cookie.Handlers.Connection
{
    public static class ConnectionHandler
    {
        [NetworkMessageHandler(typeof(ProtocolRequired))]
        public static void OnProtocolRequired(DofusSocket client, ProtocolRequired message)
        {
            //
        }

        [NetworkMessageHandler(typeof(HelloConnectMessage))]
        public static async void OnHelloConnectMessage(DofusSocket client, HelloConnectMessage message)
        {
            client.Write("Connecté au serveur d'authentification.");
            var credentials = Rsa.Encrypt(message.Key, client.Account.Login, client.Account.Password, message.Salt);
            var version = new VersionExtended
            {
                Major = 2,
                Minor = 41,
                Release = 1,
                Revision = 120980,
                Patch = 0,
                BuildType = (sbyte)BuildTypeEnum.Release,
                Install = 1,
                Technology = 1
            };
            var identificationMessage = new IdentificationMessage
            {
                Autoconnect = true,
                Credentials = credentials,
                FailedAttempts = new ushort[0],
                Lang = "fr",
                ServerId = 0,
                SessionOptionalSalt = 0,
                UseCertificate = false,
                UseLoginToken = false,
                Version = version
            };
            client.Write("Envois des informations d'identification...");
            await client.Send(identificationMessage);
        }
    }
}