using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DebugLevelEnum
    {
        LevelTrace = 0,
        LevelDebug = 1,
        LevelInfo = 2,
        LevelWarn = 3,
        LevelError = 4,
        LevelFatal = 5
    }
}
