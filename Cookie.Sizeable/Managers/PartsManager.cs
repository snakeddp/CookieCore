using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using Cookie.Sizeable.Interfaces;

namespace Cookie.Sizeable.Managers
{
    internal static class PartsManager
    {
        static PartsManager()
        {
            var ass = typeof(ISizePart).GetTypeInfo().Assembly;

            var types =
                ass.GetTypes()
                    .Where(
                        type => type.GetTypeInfo().IsClass && !type.GetTypeInfo().IsAbstract &&
                                type.GetInterfaces().Contains(typeof(ISizePart)));

            Parts = types.Select(type => (ISizePart) Activator.CreateInstance(type)).ToImmutableList();
        }

        internal static ImmutableList<ISizePart> Parts { get; }

        public static void Init()
        {
        }
    }
}