using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TeamEnum
    {
        TeamChallenger = 0,
        TeamDefender = 1,
        TeamSpectator = 2
    }
}