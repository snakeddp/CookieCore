using Cookie.IO.Reader;
using Cookie.Network.Managers;
using Cookie.Network.Sockets;
using System;
using System.Net;

namespace Cookie.Sockets
{
    public class DofusSocket : AbstractClient
    {
        public Account Account { get; set; }

        public DofusSocket(IPEndPoint ipToConnect) : base(ipToConnect)
        {
            //
        }

        public DofusSocket(IPAddress toConnect, int port) : base(toConnect, port)
        {
            //
        }

        public override void OnReceive(ArraySegment<byte> buffer, int length)
        {
            base.OnReceive(buffer, length);

            var fbr = new FastBinaryReader(buffer.Array, length);

            while (MessageParser.TryParse(fbr, out int messageId, out int dataLength, out byte[] data))
            {
                //Write($"Received message with id = {messageId}, dataLength = {dataLength}, realLength = {data.Length}");
                Write($"Received = ({messageId})");
                MessageManager<DofusSocket>.Process(this, new FastBinaryReader(data), messageId);
            }
        }
    }
}
