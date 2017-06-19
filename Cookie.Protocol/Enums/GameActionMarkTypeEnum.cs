using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GameActionMarkTypeEnum
    {
        Glyph = 1,
        Trap = 2,
        Wall = 3,
        Portal = 4,
        Rune = 5
    }
}
