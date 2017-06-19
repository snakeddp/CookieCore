using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CraftResultEnum
    {
        CraftImpossible = 0,
        CraftFailed = 1,
        CraftSuccess = 2,
        CraftNeutral = 3
    }
}
