using System;

namespace Cookie.Core.Attributes.Class
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NetworkTypeAttribute : Attribute
    {
        public short Id { get; }
        public bool WriteId { get; }

        public NetworkTypeAttribute(short id, bool writeId = false)
        {
            Id = id;
            WriteId = writeId;
        }
    }
}
