using System;

namespace Cookie.Core.Attributes.Property
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LengthTypeAttribute : Attribute
    {
        public LengthTypeAttribute(Type typeLen, bool isCustomVar = false)
        {
            TypeLen = typeLen;
            IsCustomVar = isCustomVar;
        }

        public Type TypeLen { get; }
        public bool IsCustomVar { get; }
    }
}