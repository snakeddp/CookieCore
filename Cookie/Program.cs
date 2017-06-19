using Cookie.SerDes.Managers;
using Cookie.Sockets;
using System;
using System.Diagnostics;
using System.Net;

namespace Cookie
{
    internal class Program
    {
        public static class Timing
        {
            public static void Bench(Action toBench)
            {
                var sw = Stopwatch.StartNew();
                toBench();
                sw.Stop();

                Console.WriteLine($"This Action took {sw.ElapsedMilliseconds}ms to execute.");
            }
        }

        private static void Main(string[] args)
        {
            //Timing.Bench();

            SerDesManager.GenerateExpressions();

            var client = new DofusSocket(IPAddress.Parse("213.248.126.39"), 5555);
            client.Start();

            //D2OManager.Init();
            //D2OManager.DisplayAll<Server>();

            Console.ReadKey();
        }
    }
}