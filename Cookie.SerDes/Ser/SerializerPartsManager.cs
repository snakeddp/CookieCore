using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Ser
{
    internal class SerializerPartsManager
    {
        static SerializerPartsManager()
        {
            var ass = typeof(ISerializerPart).GetTypeInfo().Assembly;

            var types =
                ass.GetTypes()
                    .Where(
                        type => type.GetTypeInfo().IsClass && !type.GetTypeInfo().IsAbstract &&
                                type.GetInterfaces().Contains(typeof(ISerializerPart)));

            Parts = types.Select(type => (ISerializerPart) Activator.CreateInstance(type)).ToImmutableList();
        }

        internal static ImmutableList<ISerializerPart> Parts { get; }

        public static void Init()
        {
        }
    }
}