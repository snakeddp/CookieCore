
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5602)]
    public class FriendSetWarnOnConnectionMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}
