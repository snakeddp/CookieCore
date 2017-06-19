using Cookie.Core.Attributes.Class;
using Cookie.Core.Enums;
using Cookie.Core.Extensions;
using Cookie.IO.Interfaces;
using Cookie.Network.Sockets;
using Cookie.SerDes.Managers;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

// ReSharper disable InconsistentNaming

namespace Cookie.Network.Managers
{
    public static class MessageManager<TC>
        where TC : AbstractClient
    {
        private static readonly Dictionary<int, Action<TC, IReader>> Processors;

        static MessageManager()
        {
            var messages =
                Assembly.Load(new AssemblyName("Cookie.Protocol"))
                    .GetTypes()
                    .Where(m => m.GetTypeInfo().HasCustomAttribute<NetworkMessageAttribute>())
                    .ToImmutableList();

            var messagesAttr =
                messages.Select(m => m.GetTypeInfo().GetCustomAttribute<NetworkMessageAttribute>())
                    .ToImmutableList();

            Processors = new Dictionary<int, Action<TC, IReader>>(
                messages.Count(m =>
                    //m.GetTypeInfo().GetCustomAttribute<NetworkMessageAttribute>() != null));
                    m.GetTypeInfo().GetCustomAttribute<NetworkMessageAttribute>().Origin != Origin.Client));


            for (var i = 0; i < messages.Count; i++)
            {
                var message = messages[i];
                var messageAttr = messagesAttr[i];

                if (messageAttr.Origin == Origin.Client)
                    continue;

                var handler =
                (from t in Assembly.GetEntryAssembly().GetTypes()
                    from m in t.GetTypeInfo().GetMethods()
                    where m.GetCustomAttribute<NetworkMessageHandlerAttribute>() != null
                       && m.GetCustomAttribute<NetworkMessageHandlerAttribute>().NetworkMessageType == message
                    select m).FirstOrDefault();

                if (handler == null) continue; // NOTE SURE !

                var paramTC = Expression.Parameter(typeof(TC), "paramTC");
                var paramReader = Expression.Parameter(typeof(IReader), "paramReader");
                var paramMessage = Expression.Variable(message, message.Name);

                var deserializeMi = typeof(SerDesManager)
                    .GetMethod("Deserialize")
                    .MakeGenericMethod(message);

                var deserializeCall = Expression.Call(deserializeMi, paramReader);
                var handlerCall = Expression.Call(handler, paramTC, paramMessage);

                var messageAssign = Expression.Assign(paramMessage, deserializeCall);

                var block = Expression.Block(new[] { paramMessage }, messageAssign, handlerCall);

                var lambda = Expression.Lambda<Action<TC, IReader>>(block, paramTC, paramReader);

                Processors.Add(messageAttr.Id, lambda.Compile());
            }
        }

        public static void Process(TC client, IReader reader, int messageId)
        {
            if (!Processors.TryGetValue(messageId, out Action<TC, IReader> processor))
            {
                client.Write($"No handler for message ({messageId})");
                //throw new ArgumentNullException(nameof(processor));
                return;
            }

            processor(client, reader);
        }

        public static void Init()
        {
        }
    }
}