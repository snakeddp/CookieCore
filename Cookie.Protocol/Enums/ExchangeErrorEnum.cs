using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ExchangeErrorEnum
    {
        RequestImpossible = 1,
        RequestCharacterOccupied = 2,
        RequestCharacterJobNotEquiped = 3,
        RequestCharacterToolTooFar = 4,
        RequestCharacterOverloaded = 5,
        RequestCharacterNotSuscriber = 6,
        RequestCharacterRestricted = 7,
        RequestCharacterGuest = 8,
        SellError = 63,
        BuyError = 64,
        MountPaddockError = 10,
        BidSearchError = 11
    }
}
