using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CharacterRemodelingEnum
    {
        CharacterRemodelingNotApplicable = 0,
        CharacterRemodelingName = 1,
        CharacterRemodelingColors = 2,
        CharacterRemodelingCosmetic = 4,
        CharacterRemodelingBreed = 8,
        CharacterRemodelingGender = 16,
        CharacterOptRemodelingName = 32
    }
}