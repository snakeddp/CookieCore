﻿using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GameActionMarkTypeEnum
    {
        GLYPH = 1,
        TRAP = 2,
        WALL = 3,
        PORTAL = 4,
        RUNE = 5
    }
}