using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TaxCollectorStateEnum
    {
        StateCollecting = 0,
        StateWaitingForHelp = 1,
        StateFighting = 2
    }
}
