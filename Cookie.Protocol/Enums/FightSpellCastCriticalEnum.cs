using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum FightSpellCastCriticalEnum
    {
        Normal = 1,
        CriticalHit = 2,
        CriticalFail = 3
    }
}
