using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SocialGroupInvitationStateEnum
    {
        SocialGroupInvitationFailed = 0,
        SocialGroupInvitationSent = 1,
        SocialGroupInvitationCanceled = 2,
        SocialGroupInvitationOk = 3
    }
}