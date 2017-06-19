using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PrismStateEnum
    {
        PrismStateInvulnerable = 0,
        PrismStateNormal = 1,
        PrismStateAttacked = 2,
        PrismStateFighting = 3,
        PrismStateWeakened = 4,
        PrismStateVulnerable = 5,
        PrismStateDefeated = 6,
        PrismStateSabotaged = 7
    }
}
