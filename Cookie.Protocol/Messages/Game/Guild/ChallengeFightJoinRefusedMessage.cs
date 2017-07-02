using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5908)]
    public class ChallengeFightJoinRefusedMessage
    {
        [CustomVar]
        public long PlayerId { get; set; }

        public byte Reason { get; set; }
    }
}