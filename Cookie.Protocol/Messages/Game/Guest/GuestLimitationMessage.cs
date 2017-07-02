using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guest
{
    [NetworkMessage(6506)]
    public class GuestLimitationMessage
    {
        public sbyte Reason { get; set; }
    }
}