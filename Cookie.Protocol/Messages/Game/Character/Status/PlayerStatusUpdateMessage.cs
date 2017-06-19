
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Messages.Game.Character.Status
{
    [NetworkMessage(6386)]
    public class PlayerStatusUpdateMessage
    {
        public uint AccountId { get; set; }
        [CustomVar]
        public long PlayerId { get; set; }
        public PlayerStatus Status { get; set; }
    }
}
