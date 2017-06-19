
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(93)]
    public class FriendSpouseOnlineInformations : FriendSpouseInformations
    {
        public uint MapId { get; set; }
        [CustomVar]
        public ushort SubAreaId { get; set; }
        public bool InFight { get; set; }
        public bool FollowSpouse { get; set; }
    }
}
