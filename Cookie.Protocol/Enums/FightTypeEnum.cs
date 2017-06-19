using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum FightTypeEnum
    {
        FightTypeChallenge = 0,
        FightTypeAgression = 1,
        FightTypePvMa = 2,
        FightTypeMxvM = 3,
        FightTypePvM = 4,
        FightTypePvT = 5,
        FightTypePvMu = 6,
        FightTypePvpArena = 7,
        FightTypeKoh = 8,
        FightTypePvPr = 9
    }
}
