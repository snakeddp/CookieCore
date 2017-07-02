using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum BoostableCharacteristicEnum
    {
        BoostableCharacStrength = 10,
        BoostableCharacVitality = 11,
        BoostableCharacWisdom = 12,
        BoostableCharacChance = 13,
        BoostableCharacAgility = 14,
        BoostableCharacIntelligence = 15
    }
}