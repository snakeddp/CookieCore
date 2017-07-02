using System;
using Cookie.Core.Enums;

namespace Cookie.Core.Attributes.Class
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NetworkMessageAttribute : Attribute
    {
        public NetworkMessageAttribute(short id, Origin org = Origin.Both)
        {
            Id = id;
            Origin = org;
        }

        public short Id { get; }
        public Origin Origin { get; }
    }
}