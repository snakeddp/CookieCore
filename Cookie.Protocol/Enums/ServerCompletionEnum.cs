using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ServerCompletionEnum
    {
        CompletionRecomandated = 0,
        CompletionAverage = 1,
        CompletionHigh = 2,
        CompletionComingSoon = 3,
        CompletionFull = 4
    }
}
