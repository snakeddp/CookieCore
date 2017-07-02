using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum DialogTypeEnum
    {
        DialogBook = 0,
        DialogDialog = 1,
        DialogLockable = 2,
        DialogPurchasable = 3,
        DialogGuildInvitation = 4,
        DialogGuildCreate = 5,
        DialogGuildRename = 6,
        DialogMarriage = 7,
        DialogDungeonMeeting = 8,
        DialogSpellForget = 9,
        DialogTeleporter = 10,
        DialogExchange = 11,
        DialogAllianceInvitation = 12,
        DialogAllianceCreate = 13,
        DialogAllianceRename = 14,
        DialogHavenbagMeeting = 15
    }
}