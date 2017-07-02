using Cookie.Protocol.Types.Game.Friend;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5924)]
    public class FriendUpdateMessage
    {
        public FriendInformations FriendUpdated { get; set; }
    }
}