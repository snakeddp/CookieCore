using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PartStateEnum
    {
        PART_NOT_INSTALLED = 0,
        PART_BEING_UPDATER = 1,
        PART_UP_TO_DATE = 2
    }
}