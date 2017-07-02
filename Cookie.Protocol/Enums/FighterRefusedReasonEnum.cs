using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum FighterRefusedReasonEnum
    {
        FighterRefused = -1,
        FighterAccepted = 0,
        ChallengeFull = 1,
        TeamFull = 2,
        WrongAlignment = 3,
        WrongGuild = 4,
        TooLate = 5,
        MutantRefused = 6,
        WrongMap = 7,
        JustRespawned = 8,
        ImOccupied = 9,
        OpponentOccupied = 10,
        FightMyself = 11,
        InsufficientRights = 12,
        MemberAccountNeeded = 13,
        OpponentNotMember = 14,
        TeamLimitedByMaincharacter = 15,
        MultiaccountNotAllowed = 16,
        GhostRefused = 17,
        RestrictedAccount = 19,
        WrongAlliance = 20,
        AvaZone = 21,
        CompanionRefused = 22,
        NotEnoughRoom = 23,
        GuestAccount = 24
    }
}