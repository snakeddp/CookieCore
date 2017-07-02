using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum FightOptionsEnum
    {
        FightOptionSetSecret = 0,
        FightOptionSetToPartyOnly = 1,
        FightOptionSetClosed = 2,
        FightOptionAskForHelp = 3
    }
}