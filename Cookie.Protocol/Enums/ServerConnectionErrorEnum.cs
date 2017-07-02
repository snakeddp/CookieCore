using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ServerConnectionErrorEnum
    {
        ServerConnectionErrorDueToStatus = 0,
        ServerConnectionErrorNoReason = 1,
        ServerConnectionErrorAccountRestricted = 2,
        ServerConnectionErrorCommunityRestricted = 3,
        ServerConnectionErrorLocationRestricted = 4,
        ServerConnectionErrorSubscribersOnly = 5,
        ServerConnectionErrorRegularPlayersOnly = 6
    }
}