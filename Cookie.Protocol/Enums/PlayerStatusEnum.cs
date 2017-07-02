using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PlayerStatusEnum
    {
        PlayerStatusOffline = 0,
        PlayerStatusUnknown = 1,
        PlayerStatusAvailable = 10,
        PlayerStatusIdle = 20,
        PlayerStatusAfk = 21,
        PlayerStatusPrivate = 30,
        PlayerStatusSolo = 40
    }
}