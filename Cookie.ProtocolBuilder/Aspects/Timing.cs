using System;
using System.Diagnostics;

namespace Cookie.ProtocolBuilder.Aspects
{
    public static class Timing
    {
        public static void Bench(Action toBench)
        {
            var sw = Stopwatch.StartNew();
            toBench();
            sw.Stop();

            //Console.WriteLine($"> {toBench.Method.Name} took {sw.ElapsedMilliseconds}ms to execute");
        }

        public static long BenchMethod(Action toBench)
        {
            var sw = Stopwatch.StartNew();
            toBench();
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static long BenchMethod(Action toBench, int iterations)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < iterations; i++)
                toBench();

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}