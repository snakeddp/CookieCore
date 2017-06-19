
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Friend;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6356)]
    public class SpouseInformationsMessage
    {
        public FriendSpouseInformations Spouse { get; set; }
    }
}
