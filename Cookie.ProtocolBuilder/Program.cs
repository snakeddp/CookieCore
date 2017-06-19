using System.IO;
using System.Linq;
using Cookie.ProtocolBuilder.Aspects;
using Cookie.ProtocolBuilder.Builders;
using Cookie.ProtocolBuilder.Helpers;
using Cookie.ProtocolBuilder.Json;
using Cookie.ProtocolBuilder.Writers;
using static System.Console;
using static Cookie.ProtocolBuilder.Builders.ProtocolJsonBuilder;
using static Cookie.ProtocolBuilder.Extensions.StringExtensions;
#pragma warning disable 1573
namespace Cookie.ProtocolBuilder
{
    internal class Program
    {
        internal static string ProtocolJsonPath { get; set; }

        /// <summary>
        /// Shoud write the number of messages, types and enums
        /// Messages, types and enums should be handled with proper directory & file writing
        /// </summary>
        /// <param name="args">read line</param>
        internal static void Main(string[] args)
        {
            ProcessArgs(args, out D2JsonProvider d2JsonProvider);

            var typesBuilder = new ProtocolClassBuilder(d2JsonProvider.Types
                .Select(m => new TypeClassWriter(m, d2JsonProvider)));
            var messagesBuilder = new ProtocolClassBuilder(d2JsonProvider.Messages
                .Select(m => new MessageClassWriter(m, d2JsonProvider)));
            var enumsBuilder = new EnumClassBuilder(d2JsonProvider.Enums
                .Select(m => new EnumClassWriter(m, d2JsonProvider)));

            var messageBuildTime = Timing.BenchMethod(() =>
            {
                messagesBuilder.CreateRepositories();
                messagesBuilder.CreateFiles();
                messagesBuilder.WriteFiles();
            });

            var typesBuildTime = Timing.BenchMethod(() =>
            {
                typesBuilder.CreateRepositories();
                typesBuilder.CreateFiles();
                typesBuilder.WriteFiles();
            });

            var enumsBuildTime = Timing.BenchMethod(() =>
            {
                enumsBuilder.CreateRepositories();
                enumsBuilder.CreateFiles();
                enumsBuilder.WriteFiles();
            });

            WriteLine($"> Types generated in {typesBuildTime}ms");
            WriteLine($"> Messages generated in {messageBuildTime}ms");
            WriteLine($"> Enums generated in {enumsBuildTime}ms");
            WriteLine("> Press any key to exit...");
            ReadKey();
        }

        /// <summary>
        /// App logic, ask for path of d2json output if not exist
        /// If you don't have a .json file path to provide, press enter
        /// The .json will be auto-generated using d2json if app is in the current folder
        /// </summary>
        /// <param name="args">Main method args</param>
        /// <returns><see cref="D2JsonProvider"/> object wich contains classes</returns>
        internal static void ProcessArgs(string[] args, out D2JsonProvider d2JsonProvider)
        {
            Title = "Cookie Protocol Builder - DevChris";
            WriteLine("\n--------------------------------------------------------------\n");
            WriteLine(@"_________                __   .__                                                                     
\_   ___ \  ____   ____ |  | _|__| ____                                                               
/    \  \/ /  _ \ /  _ \|  |/ /  |/ __ \                                                              
\     \___(  <_> |  <_> )    <|  \  ___/                                                              
 \______  /\____/ \____/|__|_ \__|\___  >                                                             
        \/                   \/       \/                                                              
__________                __                      .__    __________      .__.__       .___            
\______   \_______  _____/  |_  ____   ____  ____ |  |   \______   \__ __|__|  |    __| _/___________ 
 |     ___/\_  __ \/  _ \   __\/  _ \_/ ___\/  _ \|  |    |    |  _/  |  \  |  |   / __ |/ __ \_  __ \
 |    |     |  | \(  <_> )  | (  <_> )  \__(  <_> )  |__  |    |   \  |  /  |  |__/ /_/ \  ___/|  | \/
 |____|     |__|   \____/|__|  \____/ \___  >____/|____/  |______  /____/|__|____/\____ |\___  >__|   
                                          \/                     \/                    \/    \/       ");
            WriteLine("\n--------------------------------------------------------------\n");
            WriteLine("> Welcome to Cookie's protocol builder !");

            ProtocolJsonPath = $@"{Directory.GetCurrentDirectory()}\DofusProtocol.json";

            if (!File.Exists(ProtocolJsonPath))
            {
                WriteLine("> Please insert json file path (it'll be auto-generated if empty)");

                // enter in loop because args parameter length = 0 when entering the app
                while (args.Length != 1)
                {
                    Write("> ");
                    args = new[] { ReadLine() };

                    if (string.IsNullOrEmpty(args[0]))
                        Throw.If(!TryBuildNewProtocol(), nameof(TryBuildNewProtocol));
                    else
                    if (args[0].IsValidPath())
                        ProtocolJsonPath = args[0];
                }
            }

            d2JsonProvider = new D2JsonProvider(ProtocolJsonPath);
        }
    }
}