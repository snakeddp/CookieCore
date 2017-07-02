using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum TeamTypeEnum
    {
        TeamTypePlayer = 0,
        TeamTypeMonster = 1,
        TeamTypeMutant = 2,
        TeamTypeTaxcollector = 3,
        TeamTypeBadPlayer = 4,
        TeamTypePrism = 5
    }
}