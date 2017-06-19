using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DirectionsEnum
    {
        DirectionEast = 0,
        DirectionSouthEast = 1,
        DirectionSouth = 2,
        DirectionSouthWest = 3,
        DirectionWest = 4,
        DirectionNorthWest = 5,
        DirectionNorth = 6,
        DirectionNorthEast = 7
    }
}
