using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum FightDispellableEnum
    {
        Dispellable = 1,
        DispellableByDeath = 2,
        DispellableByStrongDispel = 3,
        ReallyNotDispellable = 4
    }
}