using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DareErrorEnum
    {
        UknownError = 0,
        DareCreationFailed = 1,
        DareUnknown = 2,
        DareCantCancel = 3,
        DareRewardUnknown = 4
    }
}
