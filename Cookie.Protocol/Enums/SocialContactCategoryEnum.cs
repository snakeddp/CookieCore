using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SocialContactCategoryEnum
    {
        SocialContactFriend = 0,
        SocialContactSpouse = 1,
        SocialContactParty = 2,
        SocialContactGuild = 3,
        SocialContactAlliance = 4,
        SocialContactCrafter = 5,
        SocialContactInterlocutor = 6,
        SocialContactFight = 7
    }
}
