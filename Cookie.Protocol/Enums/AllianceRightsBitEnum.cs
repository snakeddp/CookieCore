using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum AllianceRightsBitEnum
    {
        AllianceRightNone = 0,
        AllianceRightBoss = 1,
        AllianceRightManagePrisms = 2,
        AllianceRightTalkInChan = 4,
        AllianceRightRecruitGuilds = 8,
        AllianceRightKickGuilds = 16,
        AllianceRightManageRights = 32
    }
}
