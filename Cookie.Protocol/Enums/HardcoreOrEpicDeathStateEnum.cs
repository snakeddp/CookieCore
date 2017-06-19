using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum HardcoreOrEpicDeathStateEnum
    {
        DeathStateAlive = 0,
        DeathStateDead = 1,
        DeathStateWaitingConfirmation = 2
    }
}
