using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PartStateEnum
    {
        PartNotInstalled = 0,
        PartBeingUpdater = 1,
        PartUpToDate = 2
    }
}