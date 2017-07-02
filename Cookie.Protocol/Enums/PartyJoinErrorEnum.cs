using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PartyJoinErrorEnum
    {
        PartyJoinErrorUnknown = 0,
        PartyJoinErrorPlayerNotFound = 1,
        PartyJoinErrorPartyNotFound = 2,
        PartyJoinErrorPartyFull = 3,
        PartyJoinErrorPlayerBusy = 4,
        PartyJoinErrorPlayerAlreadyInvited = 6,
        PartyJoinErrorPlayerTooSollicited = 7,
        PartyJoinErrorPlayerLoyal = 8,
        PartyJoinErrorUnmodifiable = 9,
        PartyJoinErrorUnmetCriterion = 10,
        PartyJoinErrorNotEnoughRoom = 11,
        PartyJoinErrorCompositionChanged = 12,
        PartyJoinErrorPlayerInTutorial = 13
    }
}