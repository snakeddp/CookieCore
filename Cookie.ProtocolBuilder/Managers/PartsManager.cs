using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

namespace Cookie.ProtocolBuilder.Managers
{
    public static class PartsManager<TP>
    {
        static PartsManager()
        {
            var ass = typeof(TP).GetTypeInfo().Assembly;

            var types =
                ass.GetTypes()
                    .Where(
                        type => type.GetTypeInfo().IsClass && !type.GetTypeInfo().IsAbstract &&
                                type.GetInterfaces().Contains(typeof(TP)));

            Parts = types.Select(type => (TP) Activator.CreateInstance(type)).ToImmutableList();
        }

        internal static ImmutableList<TP> Parts { get; }

        // Empty void to run the static ctor once
        public static void GetParts()
        {
        }
    }
}