
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6374)]
    public class OrnamentSelectRequestMessage
    {
        [CustomVar]
        public ushort OrnamentId { get; set; }
    }
}
