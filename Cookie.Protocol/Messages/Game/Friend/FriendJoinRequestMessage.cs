
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5605)]
    public class FriendJoinRequestMessage
    {
        public string Name { get; set; }
    }
}
