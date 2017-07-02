using System;

namespace Cookie.Core.Attributes.Class
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NetworkTypeAttribute : Attribute
    {
        public NetworkTypeAttribute(short id, bool writeId = false)
        {
            Id = id;
            WriteId = writeId;
        }

        public short Id { get; }
        public bool WriteId { get; }
    }
}