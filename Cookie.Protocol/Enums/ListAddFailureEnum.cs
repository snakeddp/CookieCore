using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ListAddFailureEnum
    {
        ListAddFailureUnknown = 0,
        ListAddFailureOverQuota = 1,
        ListAddFailureNotFound = 2,
        ListAddFailureEgocentric = 3,
        ListAddFailureIsDouble = 4
    }
}
