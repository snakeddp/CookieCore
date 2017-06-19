using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cookie.DataCenter.D2O;

namespace Cookie.DataCenter.Managers
{
    public static class D2OManager
    {
        private static Dictionary<string, D2OUnpacker> D2OUnpackers { get; }

        static D2OManager()
        {
            var paths = Directory.GetFiles(Path.GetFullPath(@".\D2OFiles\"), "*.d2o");

            if(!paths.Any())
                throw new ArgumentNullException(nameof(paths));

            D2OUnpackers = new Dictionary<string, D2OUnpacker>(paths.Length);
            Console.WriteLine($"{paths.Length} d2o files found !");

            foreach (var path in paths)
                D2OUnpackers.Add(Path.GetFileNameWithoutExtension(path), new D2OUnpacker(path));
        }

        public static void DisplayAll<T>()
        {
            foreach (var v in D2OUnpackers)
            {
                var unpacker = v.Value;
                var objects = unpacker.GetObjects<T>();

                foreach(var o in objects)
                    Console.WriteLine($"{o}");
            }
        }

        public static void Init()
        { }
    }
}
