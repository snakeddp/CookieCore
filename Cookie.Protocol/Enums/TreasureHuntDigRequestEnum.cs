using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TreasureHuntDigRequestEnum
    {
        TreasureHuntDigErrorUndefined = 0,
        TreasureHuntDigNewHint = 1,
        TreasureHuntDigFinished = 2,
        TreasureHuntDigWrong = 3,
        TreasureHuntDigLost = 4,
        TreasureHuntDigErrorImpossible = 5,
        TreasureHuntDigWrongAndYouKnowIt = 6
    }
}