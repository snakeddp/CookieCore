using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Friend;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5599)]
    public class FriendAddedMessage
    {
        public FriendInformations FriendAdded { get; set; }
    }
}