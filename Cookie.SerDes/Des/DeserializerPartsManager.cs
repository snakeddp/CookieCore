using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Des
{
    internal static class DeserializerPartsManager
    {
        internal static ImmutableList<IDeserializerPart> Parts { get; }

        static DeserializerPartsManager()
        {
            var ass = typeof(IDeserializerPart).GetTypeInfo().Assembly;

            var types =
                ass.GetTypes()
                    .Where(
                        type => type.GetTypeInfo().IsClass && !type.GetTypeInfo().IsAbstract && type.GetInterfaces().Contains(typeof(IDeserializerPart)));

            Parts = types.Select(type => (IDeserializerPart)Activator.CreateInstance(type)).ToImmutableList();
        }

        public static void Init()
        { }
    }
}
