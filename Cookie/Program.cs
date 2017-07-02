using System;
using System.Diagnostics;
using Cookie.SerDes.Managers;
using Cookie.Sockets;

namespace Cookie
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Timing.Bench();

            SerDesManager.GenerateExpressions();

            var client = new DofusSocket("NomDeCompte", "MotDePasse");
            client.Start();

            //D2OManager.Init();
            //D2OManager.DisplayAll<Server>();

            Console.ReadKey();
        }

        public static class Timing
        {
            public static long Bench(Action toBench)
            {
                var sw = Stopwatch.StartNew();
                toBench();
                sw.Stop();
                return sw.ElapsedMilliseconds;
            }
        }
    }
}