using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Status;

namespace Cookie.Protocol.Messages.Game.Character.Status
{
    [NetworkMessage(6387)]
    public class PlayerStatusUpdateRequestMessage
    {
        public PlayerStatus Status { get; set; }
    }
}