using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum StatsUpgradeResultEnum
    {
        None = -1,
        Success = 0,
        Restricted = 1,
        Guest = 2,
        InFight = 3,
        NotEnoughPoint = 4
    }
}