using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum MountEquipedErrorEnum
    {
        UNSET = 0,
        SET = 1,
        RIDING = 2
    }
}