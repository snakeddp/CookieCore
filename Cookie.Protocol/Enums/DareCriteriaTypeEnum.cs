using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DareCriteriaTypeEnum
    {
        MonsterId = 0,
        ChallengeId = 1,
        Idols = 2,
        IdolsScore = 3,
        MaxCharLvl = 4,
        MaxFightTurns = 5,
        MaxCountChar = 6,
        MinCountChar = 7,
        ForbiddenBreeds = 8,
        MandatoryBreeds = 9,
        MinCountMonsters = 10
    }
}