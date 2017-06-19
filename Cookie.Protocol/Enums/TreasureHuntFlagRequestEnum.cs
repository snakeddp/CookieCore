using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TreasureHuntFlagRequestEnum
    {
        TreasureHuntFlagErrorUndefined = 0,
        TreasureHuntFlagOk = 1,
        TreasureHuntFlagWrong = 2,
        TreasureHuntFlagTooMany = 3,
        TreasureHuntFlagErrorImpossible = 4,
        TreasureHuntFlagWrongIndex = 5,
        TreasureHuntFlagSameMap = 6
    }
}
