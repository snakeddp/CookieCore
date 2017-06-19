using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PrismListenEnum
    {
        PrismListenNone = 0,
        PrismListenMine = 1,
        PrismListenAll = 2
    }
}
