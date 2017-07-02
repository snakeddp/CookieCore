using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GameHierarchyEnum
    {
        Unavailable = -1,
        Player = 0,
        Moderator = 10,
        GamemasterPadawan = 20,
        Gamemaster = 30,
        Admin = 40
    }
}