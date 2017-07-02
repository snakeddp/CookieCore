using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cookie.SerDes.Managers;

namespace Cookie.Network.Sockets
{
    public abstract class AbstractClient
    {
        private readonly CancellationToken _receiveLoopToken;

        protected AbstractClient(IPAddress toConnect, int port)
        {
            _receiveLoopToken = new CancellationToken();
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var toConnectEndPoint = new IPEndPoint(toConnect, port);
            Socket.Connect(toConnectEndPoint);
        }

        protected AbstractClient(IPEndPoint ipToConnect) :
            this(ipToConnect.Address, ipToConnect.Port)
        {
        }

        public Socket Socket { get; set; }
        public EndPoint SocketIp => Socket.RemoteEndPoint;

        public void Start()
        {
            LaunchReceiveLoop();
        }

        public void Stop()
        {
            //
        }

        public void Write(string message)
        {
            Console.WriteLine($"{message}");
        }

        public virtual void OnCreate()
        {
            Write("Client created");
        }

        public virtual void OnReceive(ArraySegment<byte> buffer, int length)
        {
        } /* => Write($"Received {length} bytes");*/

        public Task LaunchReceiveLoop()
        {
            return Task.Run(
                async () =>
                {
                    try
                    {
                        for (;;)
                        {
                            var segment = new ArraySegment<byte>(new byte[4096]);

                            var length =
                                await Socket.ReceiveAsync(segment, SocketFlags.None);

                            if (length < 1)
                                Socket.Dispose();

                            OnReceive(segment, length);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }, _receiveLoopToken);
        }

        public async Task Send<T>(T message)
        {
            try
            {
                var buffer = SerDesManager.Serialize(message);

                await Socket.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                //Write($"{message.GetType().Name} sent");
                Write($"Sent = ({message.GetType().Name})");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task SendMultiple(object[] messages)
        {
            if (!messages.Any())
                throw new ArgumentNullException();

            await Socket.SendAsync(new ArraySegment<byte>(SerDesManager.Serialize(messages)), SocketFlags.None);

            foreach (var message in messages)
                Write($"{message} sended");
        }
    }
}