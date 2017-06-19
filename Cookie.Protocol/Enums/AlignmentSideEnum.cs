using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum AlignmentSideEnum
    {
        AlignmentUnknown = -2,
        AlignmentWithout = -1,
        AlignmentNeutral = 0,
        AlignmentAngel = 1,
        AlignmentEvil = 2,
        AlignmentMercenary = 3
    }
}
