using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TreasureHuntFlagStateEnum
    {
        TreasureHuntFlagStateUnknown = 0,
        TreasureHuntFlagStateOk = 1,
        TreasureHuntFlagStateWrong = 2
    }
}