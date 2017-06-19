
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Script
{
    [NetworkMessage(6053)]
    public class CinematicMessage
    {
        [CustomVar]
        public ushort CinematicId { get; set; }
    }
}
