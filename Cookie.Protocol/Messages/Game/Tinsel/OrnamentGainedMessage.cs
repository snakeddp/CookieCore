using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6368)]
    public class OrnamentGainedMessage
    {
        public ushort OrnamentId { get; set; }
    }
}