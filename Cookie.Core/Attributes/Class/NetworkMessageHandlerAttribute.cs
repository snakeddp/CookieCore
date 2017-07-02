using System;

namespace Cookie.Core.Attributes.Class
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NetworkMessageHandlerAttribute : Attribute
    {
        public NetworkMessageHandlerAttribute(Type networkMessageType)
        {
            NetworkMessageType = networkMessageType;
        }

        public Type NetworkMessageType { get; }
    }
}