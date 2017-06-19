using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TreasureHuntRequestEnum
    {
        TreasureHuntErrorUndefined = 0,
        TreasureHuntErrorNoQuestFound = 2,
        TreasureHuntErrorAlreadyHaveQuest = 3,
        TreasureHuntErrorNotAvailable = 4,
        TreasureHuntOk = 1
    }
}
