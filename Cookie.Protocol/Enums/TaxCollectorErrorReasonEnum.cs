using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TaxCollectorErrorReasonEnum
    {
        TaxCollectorErrorUnknown = 0,
        TaxCollectorNotFound = 1,
        TaxCollectorNotOwned = 2,
        TaxCollectorNoRights = 3,
        TaxCollectorMaxReached = 4,
        TaxCollectorAlreadyOne = 5,
        TaxCollectorCantHireYet = 6,
        TaxCollectorCantHireHere = 7,
        TaxCollectorNotEnoughKamas = 8
    }
}