using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PlayerStateEnum
    {
        NotConnected = 0,
        GameTypeRoleplay = 1,
        GameTypeFight = 2,
        UnknownState = 99
    }
}
