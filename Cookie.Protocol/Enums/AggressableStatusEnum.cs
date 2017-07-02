using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum AggressableStatusEnum
    {
        NonAggressable = 0,
        PvPEnabledAggressable = 10,
        PvPEnabledNonAggressable = 11,
        AvAEnabledAggressable = 20,
        AvAEnabledNonAggressable = 21,
        AvADisqualified = 22,
        AvAPrequalifiedAggressable = 23
    }
}