using System;
using System.Net;
using Cookie.IO.Reader;
using Cookie.Network.Managers;
using Cookie.Network.Sockets;

namespace Cookie.Sockets
{
    public class DofusSocket : AbstractClient
    {
        public DofusSocket(string login, string password) : base(IPAddress.Parse("213.248.126.39"), 5555)
        {
            Account = new Account(login, password);
        }

        public Account Account { get; set; }

        public override void OnReceive(ArraySegment<byte> buffer, int length)
        {
            base.OnReceive(buffer, length);

            var fbr = new FastBinaryReader(buffer.Array, length);

            while (MessageParser.TryParse(fbr, out int messageId, out int dataLength, out byte[] data))
            {
                Write($"Received message with id = {messageId}, dataLength = {dataLength}, realLength = {data.Length}");
                MessageManager<DofusSocket>.Process(this, new FastBinaryReader(data), messageId);
            }
        }
    }
}