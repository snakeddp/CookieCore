using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum NicknameGeneratingFailureEnum
    {
        NicknameGeneratorRetryTooShort = 1,
        NicknameGeneratorUnavailable = 2
    }
}
