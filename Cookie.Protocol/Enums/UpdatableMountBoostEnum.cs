using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum UpdatableMountBoostEnum
    {
        Stamina = 3,
        Maturity = 5,
        Energy = 1,
        Serenity = 2,
        Love = 4,
        Tiredness = 6,
        Rideable = 7
    }
}
