using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ConsoleMessageTypeEnum
    {
        ConsoleTextMessage = 0,
        ConsoleInfoMessage = 1,
        ConsoleErrMessage = 2
    }
}
