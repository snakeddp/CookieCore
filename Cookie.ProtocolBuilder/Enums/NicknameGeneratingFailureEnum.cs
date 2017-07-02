using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum NicknameGeneratingFailureEnum
    {
        NICKNAME_GENERATOR_RETRY_TOO_SHORT = 1,
        NICKNAME_GENERATOR_UNAVAILABLE = 2
    }
}