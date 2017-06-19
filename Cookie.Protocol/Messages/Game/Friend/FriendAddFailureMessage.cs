
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5600)]
    public class FriendAddFailureMessage
    {
        public sbyte Reason { get; set; }
    }
}
