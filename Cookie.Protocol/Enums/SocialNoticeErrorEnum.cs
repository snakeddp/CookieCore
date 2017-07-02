using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SocialNoticeErrorEnum
    {
        SocialNoticeUnknownError = 0,
        SocialNoticeInvalidRights = 1,
        SocialNoticeCooldown = 2
    }
}