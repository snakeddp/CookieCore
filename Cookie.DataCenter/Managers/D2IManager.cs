using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cookie.DataCenter.D2I;
using Cookie.DataCenter.D2O;

namespace Cookie.DataCenter.Managers
{
    public static class D2IManager
    {
        private static D2IUnpacker D2IUnpacker { get; }

        static D2IManager()
        {
            var path = Path.GetFullPath(@".\D2IFiles\i18n_fr.d2i");

            D2IUnpacker = new D2IUnpacker(path);
            Console.WriteLine($"i18n_fr.d2i file found !");
        }

        public static string FindTextById(int id)
            => D2IUnpacker.GetTextById(id);

        public static void Init()
        { }
    }
}
