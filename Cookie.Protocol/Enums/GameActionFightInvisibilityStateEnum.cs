using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum GameActionFightInvisibilityStateEnum
    {
        Invisible = 1,
        Detected = 2,
        Visible = 3
    }
}