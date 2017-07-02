using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PresetSaveResultEnum
    {
        PRESET_SAVE_OK = 1,
        PRESET_SAVE_ERR_UNKNOWN = 2,
        PRESET_SAVE_ERR_TOO_MANY = 3
    }
}