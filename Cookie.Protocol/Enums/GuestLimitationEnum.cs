using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GuestLimitationEnum
    {
        LimitedToRegistered = 0,
        GuestLimitOnJobXp = 1,
        GuestLimitOnJobUse = 2,
        GuestLimitOnMap = 3,
        GuestLimitOnItem = 4,
        GuestLimitOnVendor = 5,
        GuestLimitOnChat = 6,
        GuestLimitOnGuild = 7
    }
}
