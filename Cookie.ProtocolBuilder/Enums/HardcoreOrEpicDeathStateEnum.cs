using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum HardcoreOrEpicDeathStateEnum
    {
        DEATH_STATE_ALIVE = 0,
        DEATH_STATE_DEAD = 1,
        DEATH_STATE_WAITING_CONFIRMATION = 2
    }
}