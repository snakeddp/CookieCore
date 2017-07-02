using System.Diagnostics;
using System.IO;

namespace Cookie.ProtocolBuilder.Builders
{
    public static class ProtocolJsonBuilder
    {
        /// <summary>
        ///     Build new DofusProtocol.json to current directory
        ///     TODO Warning: UNTESTED
        /// </summary>
        /// <returns>
        ///     Result of process starting and json file creating
        /// </returns>
        /// <remarks>
        ///     d2json.exe must be in the current directory (where you launch the program)
        /// </remarks>
        public static bool TryBuildNewProtocol()
        {
            var invokerPath = $@"C:\Users\devchris\AppData\Local\Ankama\Dofus\app\DofusInvoker.swf";
            var jsonFilePath = $@"{Directory.GetCurrentDirectory()}\DofusProtocol.json";

            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments =
                    $@"d2json.exe {invokerPath} > {Directory.GetCurrentDirectory()}\DofusProtocol.json",

                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            bool success;

            using (var pr = new Process())
            {
                pr.StartInfo = startInfo;
                success = pr.Start();
                pr.StandardInput.WriteLine($@"d2json.exe {invokerPath} > {jsonFilePath}");

                // wait to kill process
                pr.Kill();
            }

            return success && File.Exists(jsonFilePath);
        }
    }
}