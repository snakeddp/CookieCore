using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ClientTechnologyEnum
    {
        ClientTechnologyUnknown = 0,
        ClientAir = 1,
        ClientFlash = 2
    }
}