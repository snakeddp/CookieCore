using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum ClientInstallTypeEnum
    {
        ClientInstallUnknown = 0,
        ClientBundle = 1,
        ClientStreaming = 2
    }
}
