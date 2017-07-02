using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6077)]
    public class FriendSetWarnOnLevelGainMessage
    {
        [RegularBool]
        public bool Enable { get; set; }
    }
}