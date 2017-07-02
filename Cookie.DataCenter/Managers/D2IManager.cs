using System;
using System.IO;
using Cookie.DataCenter.D2I;

namespace Cookie.DataCenter.Managers
{
    public static class D2IManager
    {
        static D2IManager()
        {
            var path = Path.GetFullPath(@".\D2IFiles\i18n_fr.d2i");

            D2IUnpacker = new D2IUnpacker(path);
            Console.WriteLine($"i18n_fr.d2i file found !");
        }

        private static D2IUnpacker D2IUnpacker { get; }

        public static string FindTextById(int id)
        {
            return D2IUnpacker.GetTextById(id);
        }

        public static void Init()
        {
        }
    }
}