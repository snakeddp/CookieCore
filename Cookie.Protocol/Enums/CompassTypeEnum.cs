using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum CompassTypeEnum
    {
        CompassTypeSimple = 0,
        CompassTypeSpouse = 1,
        CompassTypeParty = 2,
        CompassTypePvpSeek = 3,
        CompassTypeQuest = 4
    }
}