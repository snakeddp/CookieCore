using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum NicknameErrorEnum
    {
        AlreadyUsed = 1,
        SameAsLogin = 2,
        TooSimilarToLogin = 3,
        InvalidNick = 4,
        UnknownNickError = 99
    }
}