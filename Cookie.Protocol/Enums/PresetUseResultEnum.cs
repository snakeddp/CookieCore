using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum PresetUseResultEnum
    {
        PresetUseOk = 1,
        PresetUseOkPartial = 2,
        PresetUseErrUnknown = 3,
        PresetUseErrCriterion = 4,
        PresetUseErrBadPresetId = 5,
        PresetUseErrCooldown = 6
    }
}
