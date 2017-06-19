
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5603)]
    public class FriendDeleteRequestMessage
    {
        public uint AccountId { get; set; }
    }
}
