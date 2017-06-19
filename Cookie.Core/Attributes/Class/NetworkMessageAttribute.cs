using System;
using Cookie.Core.Enums;

namespace Cookie.Core.Attributes.Class
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NetworkMessageAttribute : Attribute
    {
        public short Id { get; }
        public Origin Origin { get; }

        public NetworkMessageAttribute(short id, Origin org = Origin.Both)
        {
            Id = id;
            Origin = org;
        }
    }
}
