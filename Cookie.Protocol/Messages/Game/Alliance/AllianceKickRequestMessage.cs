
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6400)]
    public class AllianceKickRequestMessage
    {
        [CustomVar]
        public uint KickedId { get; set; }
    }
}
