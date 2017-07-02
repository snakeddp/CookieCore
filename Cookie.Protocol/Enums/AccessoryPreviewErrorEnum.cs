using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum AccessoryPreviewErrorEnum
    {
        PreviewError = 0,
        PreviewCooldown = 1,
        PreviewBadItem = 2
    }
}