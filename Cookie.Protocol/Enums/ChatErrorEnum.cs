using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ChatErrorEnum
    {
        ChatErrorUnknown = 0,
        ChatErrorReceiverNotFound = 1,
        ChatErrorInteriorMonologue = 2,
        ChatErrorNoGuild = 3,
        ChatErrorNoParty = 4,
        ChatErrorAlliance = 5,
        ChatErrorInvalidMap = 6,
        ChatErrorNoPartyArena = 7,
        ChatErrorNoTeam = 8,
        ChatErrorMalformedContent = 9
    }
}
