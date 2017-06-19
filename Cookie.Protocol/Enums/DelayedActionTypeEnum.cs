using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DelayedActionTypeEnum
    {
        DelayedActionDisconnect = 0,
        DelayedActionObjectUse = 1,
        DelayedActionJoinCharacter = 2,
        DelayedActionAggressionImmune = 3
    }
}
