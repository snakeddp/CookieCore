﻿using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GameHierarchyEnum
    {
        UNAVAILABLE = -1,
        PLAYER = 0,
        MODERATOR = 10,
        GAMEMASTER_PADAWAN = 20,
        GAMEMASTER = 30,
        ADMIN = 40
    }
}