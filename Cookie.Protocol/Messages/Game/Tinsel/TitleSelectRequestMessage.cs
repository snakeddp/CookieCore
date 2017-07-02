using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6365)]
    public class TitleSelectRequestMessage
    {
        [CustomVar]
        public ushort TitleId { get; set; }
    }
}