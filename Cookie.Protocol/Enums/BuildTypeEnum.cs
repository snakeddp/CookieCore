using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum BuildTypeEnum
    {
        Release = 0,
        Beta = 1,
        Alpha = 2,
        Testing = 3,
        Internal = 4,
        Debug = 5,
        Experimental = 6
    }
}
