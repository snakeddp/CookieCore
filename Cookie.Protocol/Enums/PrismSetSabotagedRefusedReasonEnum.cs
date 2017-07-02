using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PrismSetSabotagedRefusedReasonEnum
    {
        SabotageRefused = -1,
        SabotageInsufficientRights = 0,
        SabotageMemberAccountNeeded = 1,
        SabotageRestrictedAccount = 2,
        SabotageWrongAlliance = 3,
        SabotageNoPrism = 4,
        SabotageWrongState = 5
    }
}