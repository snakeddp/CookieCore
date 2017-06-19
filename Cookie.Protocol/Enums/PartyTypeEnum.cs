using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PartyTypeEnum
    {
        PartyTypeUndefined = 0,
        PartyTypeClassical = 1,
        PartyTypeDungeon = 2,
        PartyTypeArena = 3
    }
}
