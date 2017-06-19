using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PlayerLifeStatusEnum
    {
        StatusAliveAndKicking = 0,
        StatusTombstone = 1,
        StatusPhantom = 2
    }
}
