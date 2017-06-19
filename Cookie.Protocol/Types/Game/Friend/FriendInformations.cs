
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(78)]
    public class FriendInformations : AbstractContactInformations
    {
        public sbyte PlayerState { get; set; }
        [CustomVar]
        public ushort LastConnection { get; set; }
        public int AchievementPoints { get; set; }
    }
}
