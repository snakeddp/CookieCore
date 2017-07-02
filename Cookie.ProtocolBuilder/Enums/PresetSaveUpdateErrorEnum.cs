﻿using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PresetSaveUpdateErrorEnum
    {
        PRESET_UPDATE_ERR_UNKNOWN = 1,
        PRESET_UPDATE_ERR_BAD_PRESET_ID = 2,
        PRESET_UPDATE_ERR_BAD_POSITION = 3,
        PRESET_UPDATE_ERR_BAD_OBJECT_ID = 4
    }
}