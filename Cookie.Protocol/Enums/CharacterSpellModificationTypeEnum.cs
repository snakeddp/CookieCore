using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CharacterSpellModificationTypeEnum
    {
        InvalidModification = 0,
        Rangeable = 1,
        Damage = 2,
        BaseDamage = 3,
        HealBonus = 4,
        ApCost = 5,
        CastInterval = 6,
        CastIntervalSet = 7,
        CriticalHitBonus = 8,
        CastLine = 9,
        Los = 10,
        MaxCastPerTurn = 11,
        MaxCastPerTarget = 12,
        Range = 13
    }
}
