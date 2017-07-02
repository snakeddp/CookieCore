using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CharacterCreationResultEnum
    {
        Ok = 0,
        ErrNoReason = 1,
        ErrInvalidName = 2,
        ErrNameAlreadyExists = 3,
        ErrTooManyCharacters = 4,
        ErrNotAllowed = 5,
        ErrNewPlayerNotAllowed = 6,
        ErrRestricedZone = 7
    }
}