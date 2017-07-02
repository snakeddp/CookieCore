﻿using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DirectionsEnum
    {
        DIRECTION_EAST = 0,
        DIRECTION_SOUTH_EAST = 1,
        DIRECTION_SOUTH = 2,
        DIRECTION_SOUTH_WEST = 3,
        DIRECTION_WEST = 4,
        DIRECTION_NORTH_WEST = 5,
        DIRECTION_NORTH = 6,
        DIRECTION_NORTH_EAST = 7
    }
}