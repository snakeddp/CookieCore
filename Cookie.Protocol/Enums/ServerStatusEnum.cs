using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ServerStatusEnum
    {
        StatusUnknown = 0,
        Offline = 1,
        Starting = 2,
        Online = 3,
        Nojoin = 4,
        Saving = 5,
        Stoping = 6,
        Full = 7
    }
}